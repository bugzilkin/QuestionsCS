using System;
using NUnit.Framework;
using AK.QuestionsCS;

namespace UnitTests
{
    [TestFixture]
    [Category("MximumProductCalculator")]
    public class MximumProductCalculatorTests
    {
        [Test(Description = "Test to get index of the greatest element")]
        public void GetIndexOfMaximumTest()
        {
            var array = new int[] { 1, 2, 3, 4 };
            const int indexOfMaximum = 3;

            var calc = new MaximumProductCalculator();
            var maxProd = calc.GetIndexOfMaximum(array);

            Assert.AreEqual(indexOfMaximum, maxProd);
        }

        [Test(Description = "Test to get index of the greatest element with exclusion")]
        public void GetIndexOfMaximumWithExclusionTest()
        {
            var array = new int[] { 1, 2, 5, 4 };
            const int indexOMaximumWithExclusion = 3;
            const int indexToExclude = 2;

            var calc = new MaximumProductCalculator();
            var maxProd = calc.GetIndexOfMaximum(array, indexToExclude);

            Assert.AreEqual(indexOMaximumWithExclusion, maxProd);
        }
        
        [TestCase(new int[] { 1, 2, 5, 4 }, ExpectedResult = 20)]
        [TestCase(new int[] { 1, 5, 5 }, ExpectedResult = 25)]
        [TestCase(new int[] { 0, 2, 5, -4 }, ExpectedResult = 10)]
        [TestCase(new int[] { 1, }, ExpectedResult = 1)]
        [TestCase(new int[] { -1, -2, -5, 0 }, ExpectedResult = 0)]
        public int? GetMaximumProductTest(int[] input)
        {
            var calc = new MaximumProductCalculator();
            return calc.GetMaximumProduct(input);
        }

        [Test(Description = "Test for exceptions of the method to get maximim product of two numbers in an array")]
        public void GetMaximumProductExceptionsTest()
        {
            var calc = new MaximumProductCalculator();
            Assert.Throws(typeof(ArgumentNullException), () => calc.GetMaximumProduct(null));
            Assert.Throws(typeof(ApplicationException), () => calc.GetMaximumProduct(new int[0]));
            Assert.Throws(typeof(ApplicationException), () => calc.GetMaximumProduct(new int[] { Int32.MaxValue, Int32.MaxValue}));
        }
    }
}
