﻿using System;
using System.Linq;
namespace Calculator
{
    public class Calculator
    {
        public int Add(params int[] numbers)
        {
            return numbers.Sum();
        }

        public int Subtract(params int [] numbers)
        {
            throw new NotImplementedException();
        }








    }
}
