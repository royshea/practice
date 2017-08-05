using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice;

namespace TestPractice
{
    [TestClass]
    public class AccountBalanceTest
    {
        [TestMethod]
        public void TestMakeExpression0()
        {
            var result = AccountBalance.processTransactions(
                100,
                new string[] { "C 1000", "D 500", "D 350" });
            Assert.AreEqual(250, result);
        }

        [TestMethod]
        public void TestMakeExpression1()
        {
            var result = AccountBalance.processTransactions(
                100,
                new string[] { });
            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void TestMakeExpression2()
        {
            var result = AccountBalance.processTransactions(
                100,
                new string[] { "D 50", "D 20", "D 40" });
            Assert.AreEqual(-10, result);
        }

        [TestMethod]
        public void TestMakeExpression3()
        {
            var result = AccountBalance.processTransactions(
                53874,
                new string[] { "D 1234", "C 987", "D 2345", "C 654", "D 6789", "D 34567"});
            Assert.AreEqual(10580, result);
        }
    }
}
