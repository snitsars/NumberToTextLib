using Demo.NumberToText.Interfaces;
using System;

namespace Demo.NumberToText.UsageExample
{
    class UsageExampleProgram
    {
        static void Main(string[] args)
        {
            INumberConverter converter = new EnglishNumberConverter();

            while (Console.ReadKey().Key !=  ConsoleKey.Escape)
            {
                Console.WriteLine("Please enter your number:");
                if (decimal.TryParse(Console.ReadLine(), out var numb))
                    Console.WriteLine("Result: {0}", converter.Convert(numb));
            }
        }
    }
}
