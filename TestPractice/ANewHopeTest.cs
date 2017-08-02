using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice;

namespace TestPractice
{
    [TestClass]
    public class ANewHopeTest
    {
        [TestMethod]
        public void TestCount0()
        {
            var numWeeks = ANewHope.count(
                new int[] { 1, 2, 3, 4 },
                new int[] { 4, 3, 2, 1 },
                3);
            Assert.AreEqual(4, numWeeks);
        }

        [TestMethod]
        public void TestCount1()
        {
            var numWeeks = ANewHope.count(
                new int[] { 8, 5, 4, 1, 7, 6, 3, 2 },
                new int[] { 2, 4, 6, 8, 1, 3, 5, 7 },
                3);
            Assert.AreEqual(3, numWeeks);
        }

        [TestMethod]
        public void TestCount2()
        {
            var numWeeks = ANewHope.count(
                new int[] { 1, 2, 3, 4 },
                new int[] { 1, 2, 3, 4 },
                2);
            Assert.AreEqual(1, numWeeks);
        }
    }
}
