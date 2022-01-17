using Xunit;

namespace FizzBuzzKataGitHubTests
{
    public class FizzBuzzTests
    {
        private readonly string Hyphen = "-";
        private readonly string Fizz = "Fizz";
        private readonly string Buzz = "Buzz";
        private readonly string FizzBuzz = "FizzBuzz";

        [Fact]
        public void InputIsOne_ShouldReturnHyphen()
        {
            // Arrange
            var c = new FizzBuzzKataGitHub.Converter();

            // Act
            string output = c.Convert(1);

            // Assert
            Assert.Equal(Hyphen, output);
        }

        [Fact]
        public void InputIsThree_ShouldReturnFizz()
        {
            // Arrange
            var c = new FizzBuzzKataGitHub.Converter();

            // Act
            string output = c.Convert(3);

            // Assert
            Assert.Equal(Fizz, output);
        }

        [Fact]
        public void InputIsFive_ShouldReturnBuzz()
        {
            // Arrange
            var c = new FizzBuzzKataGitHub.Converter();

            // Act
            string output = c.Convert(5);

            // Assert
            Assert.Equal(Buzz, output);
        }
    }
}
