using System;
using System.Reflection.Metadata.Ecma335;
using System.Linq;
using System.Text;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inp = input.ToCharArray();

            string digits = "";
            string letters = "";
            string symbols = "";
            foreach(char c in inp)
            {
                if(char.IsDigit(c))
                {
                    digits += c;
                }
                else if(char.IsLetter(c))
                {
                    letters += c;
                }
                else
                {
                    symbols += c;
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);
        }
    }
}