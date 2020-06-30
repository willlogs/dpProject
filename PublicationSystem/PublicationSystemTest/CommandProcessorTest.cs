using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PublicationSystem;

namespace PublicationSystemTest
{
    [TestClass]
    class CommandProcessorTest
    {
        [TestMethod]
        public void TestWrongCommand()
        {
            CommandProcessor cp = new CommandProcessor();

            Assert.ThrowsException<Exception>(() => cp.ParseCommand("hi"));
        }

        [TestMethod]
        public void TestTest()
        {
            int i = 0;

            Assert.AreEqual(0, i);
        }
    }
}
