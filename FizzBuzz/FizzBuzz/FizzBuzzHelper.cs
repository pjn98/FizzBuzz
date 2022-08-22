using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public static class FizzBuzzHelper
    {
        public static bool IsDivisible(int dividend, int divisor)
        {
            return dividend % divisor == 0;
        }

        public static IEnumerable<int> GenerateList(int startRange, int elementsCount)
        {
            return Enumerable.Range(startRange, elementsCount).ToList();
        }
    }
}
