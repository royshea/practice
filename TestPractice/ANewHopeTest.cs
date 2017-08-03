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
            // Find the minimum move required.  This is (?) the limiting factor.
            // 1: 0 -> 3 .. 0 - 3 = -3
            // 2: 1 -> 2 .. 1 - 2 = -1
            // 3: 2 -> 1 .. 2 - 1 =  1
            // 4: 3 -> 0 .. 3 - 0 =  3
            //
            // How far can a shirt move each week?
            // (4_week - 3_wash) = 1_move
            //
            // Must have enough weeks (after the first) to be at least equal to the move
            // 1_move * weeks >= 3
            // weeks >= 3 / 1 == 3
            //
            // 3 weeks after first means 3 + 1 weeks for 4
            Assert.AreEqual(4, numWeeks);
        }

        [TestMethod]
        public void TestCount1()
        {
            var numWeeks = ANewHope.count(
                new int[] { 8, 5, 4, 1, 7, 6, 3, 2 },
                new int[] { 2, 4, 6, 8, 1, 3, 5, 7 },
                // 1: 3 - 5 = -3 
                // 2: 7 - 0 =  7
                // ...
                //
                // (8_week - 3_wash) = 5_move
                //
                // weeks >= 7 / 5 == 2
                //
                // 2 + 1 = 3 weeks
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
