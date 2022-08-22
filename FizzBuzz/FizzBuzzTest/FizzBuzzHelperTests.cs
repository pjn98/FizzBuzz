using System.Linq;
using FizzBuzz;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzHelperTests
    {
        [Fact]
        public void IsDivisible_ShouldReturnTrue_WhenNumberIsDivisibleByThree()
        {
            var isDivisibleByThree = FizzBuzzHelper.IsDivisible(3, 3);
            Assert.True(isDivisibleByThree);
        }

        [Fact]
        public void IsDivisible_ShouldReturnFalse_WhenNumberIsNotDivisibleByThree()
        {
            var isNotDivisibleByThree = FizzBuzzHelper.IsDivisible(4, 3);
            Assert.False(isNotDivisibleByThree);
        }

        [Fact]
        public void IsDivisible_ShouldReturnTrue_WhenNumberIsDivisibleByFive()
        {
            var isDivisibleByFive = FizzBuzzHelper.IsDivisible(10, 5);
            Assert.True(isDivisibleByFive);
        }

        [Fact]
        public void IsDivisible_ShouldReturnFalse_WhenNumberIsNotDivisibleByFive()
        {
            var isNotDivisibleByFive = FizzBuzzHelper.IsDivisible(8, 5);
            Assert.False(isNotDivisibleByFive);
        }

        [Fact]
        public void GenerateList_ShouldReturnTenElements_WhenStartRangeIsOneAndElementCountIsTen()
        {
            var generatedList = FizzBuzzHelper.GenerateList(1, 10);
            Assert.Equal(10, generatedList.Count());
        }
    }
}