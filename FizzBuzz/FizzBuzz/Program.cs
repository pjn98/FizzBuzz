using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            IFizzBuzz fizzBuzz = new FizzBuzz(1, 100);
            fizzBuzz.DisplayFizzBuzz();
            Console.ReadKey();
        }
    }
}