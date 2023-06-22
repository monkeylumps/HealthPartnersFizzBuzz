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

            var result = sut.GetFizzBuzzOutput(2);

            Assert.Equal(expected, result);
        }
    }
}