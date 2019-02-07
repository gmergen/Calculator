using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(1, 1, 2)]
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
        public void SubtractTest(int a, int b, int expected)
        {
            Calculator calculator = new Calculator();

            int actual = calculator.Subtract(a, b);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 3, 6)]
        public void MultiplyTest(int a, int b, int expected)
        {
            Calculator calculator = new Calculator();

            int actual = calculator.Multiply(a, b);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        public void DivideTest(int a, int b, int expected)
        {
            Calculator calculator = new Calculator();

            int actual = calculator.Divide(a, b);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData (5, 25)]
        [InlineData(10, 100)]
        public void ExponenetsTest(int a, int b, int expected)
        {
            Calculator calulator = new Calculator();

            int actual = calulator.Exponents(a, b);

            Assert.Equal(expected, actual);
        }
    }
}
