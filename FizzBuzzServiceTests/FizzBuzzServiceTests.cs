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
            var result = sut.Run(100);

            Assert.Equal(100, result.Count);
        }
    }
}