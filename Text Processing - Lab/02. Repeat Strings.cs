using System;
using System.Reflection.Metadata.Ecma335;
using System.Linq;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ").ToArray();
            string result = "";
            foreach(var word in input)
            {
                int lenghtOfWord = word.Length;
                for(int i = 0; i < lenghtOfWord; i++)
                {
                    result += word;
                }
            }
            Console.WriteLine(result);
        }
    }
}