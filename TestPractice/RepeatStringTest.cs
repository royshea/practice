using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice;

namespace TestPractice
{
    [TestClass]
    public class RepeatStringTest
    {
        [TestMethod]
        public void TestMinimalModify0()
        {
            var changes = RepeatString.minimalModify("aba");
            Assert.AreEqual(1, changes);
        }
        [TestMethod]
        public void TestMinimalModify1()
        {
            var changes = RepeatString.minimalModify("adam");
            Assert.AreEqual(1, changes);
        }
        [TestMethod]
        public void TestMinimalModify2()
        {
            var changes = RepeatString.minimalModify("x");
            Assert.AreEqual(1, changes);
        }
        [TestMethod]
        public void TestMinimalModify3()
        {
            var changes = RepeatString.minimalModify("aaabbbaaaccc");
            Assert.AreEqual(3, changes);
        }
        [TestMethod]
        public void TestMinimalModify4()
        {
            var changes = RepeatString.minimalModify("repeatstring");
            Assert.AreEqual(6, changes);
        }
        [TestMethod]
        public void TestMinimalModify5()
        {
            var changes = RepeatString.minimalModify("aaaaaaaaaaaaaaaaaaaa");
            Assert.AreEqual(0, changes);
        }
    }
}
