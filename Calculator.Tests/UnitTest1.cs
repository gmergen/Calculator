using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(-2, -4, -6)]
        public void AddTest(int a, int b, int expected)
        {
            //Arrange 
            Calculator calculator = new Calculator();

            //Act
            int actual = calculator.Add(a, b);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(6, 3, 3)]
        [InlineData(10, 5, 5)]
        public void SubtractTest(int a, int b, int expected)
        {
            Calculator calculator = new Calculator();

            int actual = calculator.Subtract(a, b);

            Assert.Equal(expected, actual);
        }

    }
}
