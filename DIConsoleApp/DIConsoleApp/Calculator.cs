using System;
using System.Collections.Generic;
using System.Text;

namespace DIConsoleApp
{
    public class Calculator : ICalculator
    {
        public int Sum(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
