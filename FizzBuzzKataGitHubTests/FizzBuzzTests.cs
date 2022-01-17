using Xunit;

namespace FizzBuzzKataGitHubTests
{
    public class FizzBuzzTests
    {
        private readonly string Hyphen = "-";

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
    }
}
