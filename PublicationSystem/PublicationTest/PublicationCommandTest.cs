using NUnit.Framework;
using PublicationSystem;
using PublicationSystem.CommandProcessing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PublicationTest
{
    public class PublicationCreationTest
    {
        private PublicationCommandExecuter commandExecuter;
        private string[] args;
        TextWriter capturer;
        TextWriter systemOutput;

        private const string SportName = "sport";
        private const string PoliticalName = "political";
        private const string EconomicName = "economical";

        [OneTimeSetUp]
        public void SetupAll()
        {
            commandExecuter = new PublicationCommandExecuter();
            commandExecuter.AddPublicationBuilder(new SportBuilder());
            commandExecuter.AddPublicationBuilder(new PoliticalBuilder());
            commandExecuter.AddPublicationBuilder(new EconomicalBuilder());
            args = new string[1];
            systemOutput = Console.Out;
        }

        [SetUp]
        public void Setup()
        {
            Console.SetOut(systemOutput);
            PublicationProvider.Instance.DestroyAllPublications();
            capturer = new StringWriter();
        }

        [TearDown]
        public void TearDown()
        {
            capturer.Dispose();
        }

        [Test]
        public void TestCreateSport()
        {
            args[0] = SportName;
            commandExecuter.Execute("createModel", args);

            Console.SetOut(capturer);
            commandExecuter.Execute("printInfo", args);

            string capturedInfo = capturer.ToString();
            Publication publication = PublicationProvider.Instance.GetPublication(SportName);
            string info = publication.ToString() + "\r\n";
            Assert.AreEqual(info, capturedInfo);
        }

        [Test]
        public void TestCreatePolitical()
        {
            args[0] = PoliticalName;
            commandExecuter.Execute("createModel", args);

            Console.SetOut(capturer);
            commandExecuter.Execute("printInfo", args);

            string capturedInfo = capturer.ToString();
            Publication publication = PublicationProvider.Instance.GetPublication(PoliticalName);
            string info = publication.ToString() + "\r\n";
            Assert.AreEqual(info, capturedInfo);
        }

        [Test]
        public void TestCreateEconomic()
        {
            args[0] = EconomicName;
            commandExecuter.Execute("createModel", args);

            Console.SetOut(capturer);
            commandExecuter.Execute("printInfo", args);

            string capturedInfo = capturer.ToString();
            Publication publication = PublicationProvider.Instance.GetPublication(EconomicName);
            string info = publication.ToString() + "\r\n";
            Assert.AreEqual(info, capturedInfo);
        }

        [Test]
        public void TestCreateAllModels()
        {
            args[0] = SportName;
            commandExecuter.Execute("createModel", args);
            args[0] = PoliticalName;
            commandExecuter.Execute("createModel", args);
            args[0] = EconomicName;
            commandExecuter.Execute("createModel", args);

            Console.SetOut(capturer);
            commandExecuter.Execute("printInfo", null);

            string capturedInfo = capturer.ToString();
            Publication sportPublication = PublicationProvider.Instance.GetPublication(SportName);
            Publication politicalPublication = PublicationProvider.Instance.GetPublication(PoliticalName);
            Publication economicalPublication = PublicationProvider.Instance.GetPublication(EconomicName);
            string info = sportPublication.ToString() + "\r\n" + politicalPublication.ToString() + "\r\n" + economicalPublication.ToString() + "\r\n";
            Assert.AreEqual(info, capturedInfo);
        }

    }
}
