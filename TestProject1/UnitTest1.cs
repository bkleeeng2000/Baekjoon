using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q2292;

namespace TestProject1
{
    [TestClass]
    public class Q2292T
    {
        [TestMethod]
        public void StartNumber()
        {
            Assert.AreEqual(1, Program.Calc(1));
        }

        [TestMethod]
        public void BetweenNumber()
        {
            Assert.AreEqual(2, Program.Calc(6));
            Assert.AreEqual(3, Program.Calc(13));
            Assert.AreEqual(4, Program.Calc(20));
            Assert.AreEqual(4, Program.Calc(36));
            Assert.AreEqual(6, Program.Calc(80));
        }

        [TestMethod]
        public void LastNumber()
        {
            Assert.AreEqual(2, Program.Calc(7));
            Assert.AreEqual(3, Program.Calc(19));
            Assert.AreEqual(4, Program.Calc(37));
            Assert.AreEqual(5, Program.Calc(61));
            Assert.AreEqual(6, Program.Calc(91));
        }
    }
}