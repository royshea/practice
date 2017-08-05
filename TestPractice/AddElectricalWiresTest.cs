using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice;

namespace TestPractice
{
    [TestClass]
    public class AddElectricalWiresTest
    {
        [TestMethod]
        public void TestMaxNewWires0()
        {
            var newWires = AddElectricalWires.maxNewWires(
                new string[] { "000","000","000"},
                new int[] { 0 });
            Assert.AreEqual(3, newWires);
        }

        [TestMethod]
        public void TestMaxNewWires1()
        {
            var newWires = AddElectricalWires.maxNewWires(
                new string[] { "000", "000", "000" },
                new int[] { 0, 1 });
            Assert.AreEqual(1, newWires);
        }

        [TestMethod]
        public void TestMaxNewWires2()
        {
            var newWires = AddElectricalWires.maxNewWires(
                new string[] { "01", "10" },
                new int[] { 0 });
            Assert.AreEqual(0, newWires);
        }

        [TestMethod]
        public void TestMaxNewWires3()
        {
            var newWires = AddElectricalWires.maxNewWires(
                new string[] { "00000", "00000", "00000", "00000", "00000" },
                new int[] { 0, 1, 2, 3, 4 });
            Assert.AreEqual(0, newWires);
        }

        [TestMethod]
        public void TestMaxNewWires4()
        {
            var newWires = AddElectricalWires.maxNewWires(
                new string[] { "01000", "10100", "01010", "00100", "00000" },
                new int[] { 2, 4 });
            Assert.AreEqual(3, newWires);
        }
    }
}