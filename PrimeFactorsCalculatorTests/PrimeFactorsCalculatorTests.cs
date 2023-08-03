using Xunit;
using System;
using PrimeFactorsLibrary;

namespace PrimeFactorsCalculatorTests
{
    public class PrimeFactorsCalculatorTests
    {
        [Fact]
        public void TestPrimeFactorsFor2()
        {
            string result = PrimeFactorsCalculator.PrimeFactors(2);
            Assert.Equal("2", result);
        }

        [Fact]
        public void TestPrimeFactorsFor12()
        {
            string result = PrimeFactorsCalculator.PrimeFactors(12);
            Assert.Equal("2 * 2 * 3", result);
        }

        [Fact]
        public void TestPrimeFactorsFor100()
        {
            string result = PrimeFactorsCalculator.PrimeFactors(100);
            Assert.Equal("2 * 2 * 5 * 5", result);
        }

        [Fact]
        public void TestPrimeFactorsFor1()
        {
            string result = PrimeFactorsCalculator.PrimeFactors(1);
            Assert.Equal("Prime factors are not defined for numbers less than 2.", result);
        }
    }
}
