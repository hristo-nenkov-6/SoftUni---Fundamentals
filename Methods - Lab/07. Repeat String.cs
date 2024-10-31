using System;
using System.Runtime.CompilerServices;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(Repeat(input, a));
        }
        static string Repeat(string str, int times)
        {
            string output = "";
            for(int i = 0; i < times; i++)
            {
                output += str;
            }
            return output;
        }
    }
}
