using System;
using Calculator;

namespace CalculatorApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Calculator.Calculator calculator = new Calculator.Calculator();

            Console.WriteLine("Írj be két számot az összeadáshoz:");
            if (int.TryParse(Console.ReadLine(), out int a) && int.TryParse(Console.ReadLine(), out int b))
            {
                int result = calculator.Add(a, b);
                Console.WriteLine($"Összeg: {result}");
            }
            else
            {
                Console.WriteLine("Érvénytelen bemenet a számokhoz.");
            }
        }
    }
}
