using System;
using calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program.Main(new string[] { "sum", "10,20,30,40" });
        }
    }
}
