using System;
using System.Reflection.Metadata.Ecma335;
using System.Linq;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            while((input = Console.ReadLine()) != "end")
            {
                char[] arrString = input.ToCharArray();
                Array.Reverse(arrString);
                string reversedString = new string(arrString);
                Console.WriteLine(input + " = " +  reversedString);
            }
        }
    }
}