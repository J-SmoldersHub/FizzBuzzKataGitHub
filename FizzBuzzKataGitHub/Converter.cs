namespace FizzBuzzKataGitHub
{
    public class Converter
    {
        private readonly string Hyphen = "-";
        private readonly string Fizz = "Fizz";

        public string Convert(int input)
        {
            return IsDivisableByThree(input)
                ? Fizz
                : Hyphen;
        }

        private bool IsDivisableByThree(int input) =>
            input % 3 == 0;
    }
}
