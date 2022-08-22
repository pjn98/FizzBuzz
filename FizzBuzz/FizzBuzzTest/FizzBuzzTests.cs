using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzTests
    {
        [Fact]
        public void DisplayFizzBuzz_ShouldBeVerifiable_ToEnsureThatItRuns()
        {
            var moq = new Mock<IFizzBuzz>();
            moq.Setup(x => x.DisplayFizzBuzz()).Verifiable();
        }
    }
}
