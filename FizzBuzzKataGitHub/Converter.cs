namespace FizzBuzzKataGitHub
{
    public class Converter
    {
        private readonly string Hyphen = "-";
        private readonly string Fizz = "Fizz";
        private readonly string Buzz = "Buzz";
        private readonly string FizzBuzz = "FizzBuzz";

        public string Convert(int input)
        {
            return IsDivisableByFive(input)
                ? IsDivisableByThree(input)
                    ? FizzBuzz
                    : Buzz
                : IsDivisableByThree(input)
                    ? Fizz
                    : Hyphen;
        }

        private bool IsDivisableByThree(int input) =>
            input % 3 == 0;

        private bool IsDivisableByFive(int input) =>
            input % 5 == 0;
    }
}
