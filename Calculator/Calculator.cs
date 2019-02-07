using System;
using System.Linq;
namespace Calculator
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }

        public double Exponents(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public int Factorials(int a, int b)
        {
            throw new NotImplementedException();
        }

    }
}
