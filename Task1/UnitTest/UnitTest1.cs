using CalcProgram;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1() => Calculator.Main(new string[] { "sum", "2,3" });
    }

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculator.Main(new string[] { "sum", "2,50" });
        }
    }
}
