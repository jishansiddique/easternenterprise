using System;
using calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program.Main(new string[] { "add", "\\;\\3;4;5" });
        }
    }
}
