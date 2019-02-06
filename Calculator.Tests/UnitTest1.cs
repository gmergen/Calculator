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
    }
}
