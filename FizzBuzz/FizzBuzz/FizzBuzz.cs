using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzz : IFizzBuzz
    {
        private readonly int _startRange;
        private readonly int _elementsCount;

        public FizzBuzz(int startRange, int elementsCount)
        {
            _startRange = startRange;
            _elementsCount = elementsCount;
        }

        public void DisplayFizzBuzz()
        {
            var elementsList = GenerateList(_startRange, _elementsCount);
            foreach (var element in elementsList)
            {
                if (IsDivisible(element, 3 * 5))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (IsDivisible(element, 3))
                {
                    Console.WriteLine("Fizz");
                }
                else if(IsDivisible(element, 5))
                {
                    Console.WriteLine("Buzz");
                }
            }
        }

        private static bool IsDivisible(int dividend, int divisor)
        {
            return dividend % divisor == 0;
        }

        private static IEnumerable<int> GenerateList(int startRange, int elementsCount)
        {
            return Enumerable.Range(startRange, elementsCount).ToList();
        }
    }
}