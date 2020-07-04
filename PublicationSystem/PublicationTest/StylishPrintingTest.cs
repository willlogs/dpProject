using NUnit.Framework;
using PublicationSystem.CommandProcessing;
using PublicationSystem.StylishPrinting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PublicationTest
{
    public class StylishPrintingTest
    {
        private StringWriter writer;
        private string inputText;
        private const string AddCommand = "add";
        private const string RemoveCommand = "remove";

        [SetUp]
        public void Setup()
        {
            writer = new StringWriter();
            inputText = "hello";
            Console.SetOut(writer);
        }

        [TearDown]
        public void TearDown()
        {
            writer.Dispose();
        }

        [Test]
        public void TestStarStyle()
        {
            StylishPrinter.PrintLine(inputText);
            StylishPrinter.AddStyle(StarStyle.Instance);
            StylishPrinter.PrintLine(inputText);
            StylishPrinter.RemoveStyle(StarStyle.Instance);
            StylishPrinter.PrintLine(inputText);

            string capturedText = writer.ToString();
            string expectedText = GetTextLine(inputText);
            expectedText += GetTextLine("*" + inputText);
            expectedText += GetTextLine(inputText);
            Assert.AreEqual(expectedText, capturedText);
        }

        [Test]
        public void TestUpperCaseStyle()
        {
            StylishPrinter.PrintLine(inputText);
            StylishPrinter.AddStyle(UpperCaseStyle.Instance);
            StylishPrinter.PrintLine(inputText);
            StylishPrinter.RemoveStyle(UpperCaseStyle.Instance);
            StylishPrinter.PrintLine(inputText);

            string capturedText = writer.ToString();
            string expectedText = GetTextLine(inputText);
            expectedText += GetTextLine(inputText.ToUpper());
            expectedText += GetTextLine(inputText);
            Assert.AreEqual(expectedText, capturedText);
        }

        [Test]
        public void TestStyleEquality()
        {
            StylishPrinter.PrintLine(inputText);
            StylishPrinter.AddStyle(new QuestionStyle());
            StylishPrinter.PrintLine(inputText);
            StylishPrinter.RemoveStyle(new QuestionStyle());
            StylishPrinter.PrintLine(inputText);

            string capturedText = writer.ToString();
            string expectedText = GetTextLine(inputText);
            expectedText += GetTextLine("?" + inputText);
            expectedText += GetTextLine(inputText);
            Assert.AreEqual(expectedText, capturedText);
        }

        [Test]
        public void TestMultiStyle()
        {
            StylishPrinter.PrintLine(inputText);
            StylishPrinter.AddStyle(StarStyle.Instance);
            StylishPrinter.PrintLine(inputText);
            StylishPrinter.AddStyle(UpperCaseStyle.Instance);
            StylishPrinter.PrintLine(inputText);
            StylishPrinter.RemoveStyle(StarStyle.Instance);
            StylishPrinter.PrintLine(inputText);
            StylishPrinter.RemoveStyle(UpperCaseStyle.Instance);
            StylishPrinter.PrintLine(inputText);

            string capturedText = writer.ToString();
            string expectedText = GetTextLine(inputText);
            expectedText += GetTextLine("*" + inputText);
            expectedText += GetTextLine("*" + inputText.ToUpper());
            expectedText += GetTextLine(inputText.ToUpper());
            expectedText += GetTextLine(inputText);
            Assert.AreEqual(expectedText, capturedText);
        }

        [Test]
        public void TestCommandsForSingleStyles()
        {
            PrintingCommandExecuter printingExecuter = new PrintingCommandExecuter();
            printingExecuter.AddStyleCommand(StarStyle.Instance);
            printingExecuter.AddStyleCommand(UpperCaseStyle.Instance);
            printingExecuter.AddStyleCommand(QuestionStyle.Instance);

            StylishPrinter.PrintLine(inputText);
            printingExecuter.Execute(AddCommand + QuestionStyle.Instance.CommandSuffix, null);
            StylishPrinter.PrintLine(inputText);
            printingExecuter.Execute(RemoveCommand + QuestionStyle.Instance.CommandSuffix, null);
            StylishPrinter.PrintLine(inputText);
            printingExecuter.Execute(AddCommand + StarStyle.Instance.CommandSuffix, null);
            StylishPrinter.PrintLine(inputText);
            printingExecuter.Execute(RemoveCommand + StarStyle.Instance.CommandSuffix, null);
            StylishPrinter.PrintLine(inputText);
            printingExecuter.Execute(AddCommand + UpperCaseStyle.Instance.CommandSuffix, null);
            StylishPrinter.PrintLine(inputText);
            printingExecuter.Execute(RemoveCommand + UpperCaseStyle.Instance.CommandSuffix, null);
            StylishPrinter.PrintLine(inputText);

            string capturedText = writer.ToString();
            string expectedText = GetTextLine(inputText);
            expectedText += GetTextLine("?" + inputText);
            expectedText += GetTextLine(inputText);
            expectedText += GetTextLine("*" + inputText);
            expectedText += GetTextLine(inputText);
            expectedText += GetTextLine(inputText.ToUpper());
            expectedText += GetTextLine(inputText);
            Assert.AreEqual(expectedText, capturedText);
        }

        [Test]
        public void TestCommandsForMultiStyle()
        {
            PrintingCommandExecuter printingExecuter = new PrintingCommandExecuter();
            printingExecuter.AddStyleCommand(StarStyle.Instance);
            printingExecuter.AddStyleCommand(UpperCaseStyle.Instance);
            printingExecuter.AddStyleCommand(QuestionStyle.Instance);

            StylishPrinter.PrintLine(inputText);
            printingExecuter.Execute(AddCommand + QuestionStyle.Instance.CommandSuffix, null);
            StylishPrinter.PrintLine(inputText);
            printingExecuter.Execute(AddCommand + StarStyle.Instance.CommandSuffix, null);
            StylishPrinter.PrintLine(inputText);
            printingExecuter.Execute(AddCommand + UpperCaseStyle.Instance.CommandSuffix, null);
            StylishPrinter.PrintLine(inputText);
            printingExecuter.Execute(RemoveCommand + UpperCaseStyle.Instance.CommandSuffix, null);
            StylishPrinter.PrintLine(inputText);
            printingExecuter.Execute(RemoveCommand + QuestionStyle.Instance.CommandSuffix, null);
            StylishPrinter.PrintLine(inputText);
            printingExecuter.Execute(RemoveCommand + StarStyle.Instance.CommandSuffix, null);
            StylishPrinter.PrintLine(inputText);

            string capturedText = writer.ToString();
            string expectedText = GetTextLine(inputText);
            expectedText += GetTextLine("?" + inputText);
            expectedText += GetTextLine("*?" + inputText);
            expectedText += GetTextLine("*?" + inputText.ToUpper());
            expectedText += GetTextLine("*?" + inputText);
            expectedText += GetTextLine("*" + inputText);
            expectedText += GetTextLine(inputText);
            Assert.AreEqual(expectedText, capturedText);
        }

        private string GetTextLine(string text)
        {
            return text + "\r\n";
        }
    }
}
