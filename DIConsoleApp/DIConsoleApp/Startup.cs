using System;
using System.Collections.Generic;
using System.Text;

namespace DIConsoleApp
{
    public class Startup
    {
        private readonly ICalculator calculator;

        public Startup(ICalculator calculator)
        {
            this.calculator = calculator;
        }

        public void Sum(string number1, string number2)
        {
            var intNumber1 = int.Parse(number1);
            var intNumber2 = int.Parse(number2);

            var result = this.calculator.Sum(intNumber1, intNumber2);

            Console.WriteLine($"Result: {result}");
        }
    }
}
