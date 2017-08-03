using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice;

namespace TestPractice
{
    [TestClass]
    public class AddMultiplyTest
    {

        int MakeResult(int[] x)
        {
            return x[0] * x[1] + x[2];
        }

        [TestMethod]
        public void TestMakeExpression0()
        {
            var y = 5;
            int[] x = AddMultiply.makeExpression(y);
            var result = MakeResult(x);
            Assert.AreEqual(y, result);
        }
    }
}
