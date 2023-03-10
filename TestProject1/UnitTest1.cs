using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void WhenEmptyStringProvided_ItShouldReturnZero()
        {
            ClassLibrary1.StringCalculator calculator = new();
            Assert.Equal(0, calculator.Add(""));
        }
        [Theory]
        [InlineData("0", 0)]
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        public void WhenSingleNumberProvided_ItShouldReturnValue(string input ,int expected)
        {
            ClassLibrary1.StringCalculator calculator = new();
            int result = calculator.Add(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("2,3", 5)]
        [InlineData("1,6", 7)]
        [InlineData("6,8", 14)]
        public void WhenTwoNumbersProvided_ItShouldReturnSum(string input, int expected)
        {
            ClassLibrary1.StringCalculator calculator = new();
            int result = calculator.Add(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("2\n3", 5)]
        [InlineData("1\n6", 7)]
        [InlineData("6\n8", 14)]
        public void WhenTwoNumbersProvidedWithEnter_ItShouldReturnSum(string input, int expected)
        {
            ClassLibrary1.StringCalculator calculator = new();
            int result = calculator.Add(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("2\n3,4", 9)]
        [InlineData("1,3\n6", 10)]
        [InlineData("6\n8\n10", 24)]
        [InlineData("1,2,3", 6)]
        public void WhenThreeNumbersProvided_ItShouldReturnSum(string input, int expected)
        {
            ClassLibrary1.StringCalculator calculator = new();
            int result = calculator.Add(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("-1\n3")]
        [InlineData("1\n-3")]
        public void WhenNegativeNumberProvided_ItShouldThrowAnException(string input)
        {
            ClassLibrary1.StringCalculator calculator = new();
            Assert.Throws<ArgumentOutOfRangeException>(() => calculator.Add(input));
        }

        [Theory]
        [InlineData("2\n3,1001", 5)]
        [InlineData("1,3000\n6", 7)]
        [InlineData("60000\n8\n10", 18)]
        [InlineData("1000,2,3000", 1002)]
        public void WhenNumbersGreaterThan1000Provided_ItShouldIgnoresThem(string input, int expected)
        {
            ClassLibrary1.StringCalculator calculator = new();
            int result = calculator.Add(input);
            Assert.Equal(expected, result);
        }
    }
}

