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

        public int Exponents(int a, int b)
        {
            return a * a;
        }

        public int Factorials(int a, int b)
        {
            throw new NotImplementedException();
        }

    }
}
