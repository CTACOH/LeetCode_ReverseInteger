using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.ReverseInteger.Tests
{
    [TestClass]
    public class ReverseIntegerSolutionTest
    {
        [TestMethod]
        public void Reverse_123_321()
        {
            int numberToReverse = 123;

            int result = new ReverseInteger().Reverse(numberToReverse);

            Assert.AreEqual(321, result);
        }

        [TestMethod]
        public void Reverse_120_21()
        {
            int numberToReverse = 120;

            int result = new ReverseInteger().Reverse(numberToReverse);

            Assert.AreEqual(21, result);
        }

        [TestMethod]
        public void Reverse_Minus123_Minus321()
        {
            int numberToReverse = -123;

            int result = new ReverseInteger().Reverse(numberToReverse);

            Assert.AreEqual(-321, result);
        }

        [TestMethod]
        public void Reverse_1294967296_0()
        {
            int numberToReverse = 1294967296;

            int result = new ReverseInteger().Reverse(numberToReverse);

            Assert.AreEqual(0, result);
        }

    }
}
