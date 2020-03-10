using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloConsole;

namespace helloConsoleTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello Console", Program.createMessage());
        }
    }
}
