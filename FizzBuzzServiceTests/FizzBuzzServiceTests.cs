using FizzBuzzService;
using Xunit;

namespace FizzBuzzServiceTests
{
    public class FizzBuzzServiceTests
    {
        private IFizzBuzzService sut;

        public FizzBuzzServiceTests()
        {
            sut = new FBService();
        }

        [Fact]
        public void GivenRange100WhenRunThenReturnListCount100()
        {
            var expected = 100;

            var result = sut.Run(100);

            Assert.Equal(expected, result.Count);
        }

        [Fact]
        public void Given2WhenGetFizzBuzzOutputThenReturn2()
        {
            var expected = "2";

            var number = 2;

            GetFizzBuzzResult(expected, number);
        }

        [Fact]
        public void Given9WhenGetFizzBuzzOutputThenReturnFizz()
        {
            var expected = "Fizz";

            var number = 9;

            GetFizzBuzzResult(expected, number);
        }

        [Fact]
        public void Given25WhenGetFizzBuzzOutputThenReturnBuzz()
        {
            var expected = "Buzz";

            var number = 25;

            GetFizzBuzzResult(expected, number);
        }

        [Fact]
        public void Given15WhenGetFizzBuzzOutputThenReturnFizzBuzz()
        {
            var expected = "FizzBuzz";

            var number = 15;

            GetFizzBuzzResult(expected, number);
        }

        private void GetFizzBuzzResult(string expected, int number)
        {
            var result = sut.GetFizzBuzzOutput(number);

            Assert.Equal(expected, result);
        }
    }
}