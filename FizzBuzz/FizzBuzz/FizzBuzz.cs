using System;

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

        public FizzBuzz()
        {
            _startRange = 1;
            _elementsCount = 100;
        }

        public void DisplayFizzBuzz()
        {
            var elementsList = FizzBuzzHelper.GenerateList(_startRange, _elementsCount);
            foreach (var element in elementsList)
            {
                if (FizzBuzzHelper.IsDivisible(element, 3 * 5))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (FizzBuzzHelper.IsDivisible(element, 3))
                {
                    Console.WriteLine("Fizz");
                }
                else if (FizzBuzzHelper.IsDivisible(element, 5))
                {
                    Console.WriteLine("Buzz");
                }
            }
        }
    }
}