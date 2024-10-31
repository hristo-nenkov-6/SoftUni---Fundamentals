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
            double result = 0;
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach(string word in  input)
            {
                char beforeLetter = word[0];
                char afterLetter = word[word.Length - 1];
                double number = double.Parse(word.Substring(1, word.Length - 2));

                if(char.IsUpper(beforeLetter))
                {
                    number = number / (beforeLetter - 64);
                }
                else
                {
                    number = number * (beforeLetter - 96);
                }

                if(char.IsUpper(afterLetter))
                {
                    number = number - (afterLetter - 64);
                }
                else
                {
                    number = number + (afterLetter - 96);
                }

                result += number;
            }
            Console.WriteLine($"{result:f2}");
        }
    }
}