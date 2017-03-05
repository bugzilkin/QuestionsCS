using System;
using NUnit.Framework;
using AK.QuestionsCS;

namespace UnitTests
{
    [TestFixture]
    [Category("BinarySearher")]
    public class BinarySearherTests
    {
        [TestCase(new int[] { 1, 2, 5, 8 }, 1, ExpectedResult = 0)]
        [TestCase(new int[] { -1, 3, 5, 9 }, 3, ExpectedResult = 1)]
        [TestCase(new int[] { 1, 2, 5, 6 }, 0, ExpectedResult = null)]
        [TestCase(new int[] { 1, 2, 5, 6 }, 10, ExpectedResult = null)]
        [TestCase(new int[] { 1, 2, 5, 6 }, 4, ExpectedResult = null)]
        [TestCase(new int[] { 1, 2, 5, 5, 7 }, 5, ExpectedResult = 2)]
        [TestCase(new int[] { 1, }, 1, ExpectedResult = 0)]
        public int? BinarySearchTest(int[] input, int x)
        {
            var calc = new BinarySearcherIterative();

            return calc.BinarySearch(input, x);
        }

        [Test]
        public void BinarySearchExceptionsTest()
        {
            var calc = new BinarySearcherIterative();
            Assert.Throws(typeof(ArgumentNullException), () => calc.BinarySearch(null, 0));
            Assert.Throws(typeof(ApplicationException), () => calc.BinarySearch(new int[0], 3));
        }

        [TestCase(new int[] { 1, 2, 5, 8 }, 1, ExpectedResult = 0)]
        [TestCase(new int[] { -1, 3, 5, 9 }, 3, ExpectedResult = 1)]
        [TestCase(new int[] { 1, 2, 5, 6 }, 0, ExpectedResult = null)]
        [TestCase(new int[] { 1, 2, 5, 6 }, 10, ExpectedResult = null)]
        [TestCase(new int[] { 1, 2, 5, 6 }, 4, ExpectedResult = null)]
        [TestCase(new int[] { 1, 2, 5, 5, 7 }, 5, ExpectedResult = 2)]
        [TestCase(new int[] { 1, }, 1, ExpectedResult = 0)]
        public int? BinarySearchRecursiveTest(int[] input, int x)
        {
            var calc = new BinarySearcherRecursive();

            return calc.BinarySearch(input, x);
        }

        [Test]
        public void BinarySearchRecursiveExceptionsTest()
        {
            var calc = new BinarySearcherRecursive();
            Assert.Throws(typeof(ArgumentNullException), () => calc.BinarySearch(null, 0));
            Assert.Throws(typeof(ApplicationException), () => calc.BinarySearch(new int[0], 3));
        }
    }
}
