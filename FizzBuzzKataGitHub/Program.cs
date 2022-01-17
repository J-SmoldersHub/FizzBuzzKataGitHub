using System;

namespace FizzBuzzKataGitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Converter();
            // this should output FizzBuzz
            Console.WriteLine(c.Convert(30));
            Console.ReadLine();
        }
    }
}
