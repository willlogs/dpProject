using NUnit.Framework;
using PublicationSystem.CommandProcessing;
using System;

namespace PublicationTest
{
    public class CommandProcessorTest
    {
        CommandProcessor cp;

        [SetUp]
        public void Setup()
        {
            cp = new CommandProcessor();
        }

        [Test]
        public void Test1()
        {
            Assert.Throws(typeof(Exception), () => cp.ParseCommand("hi"));
        }
    }
}