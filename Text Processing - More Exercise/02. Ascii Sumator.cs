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
            char start = char.Parse(Console.ReadLine());
            char finish = char.Parse(Console.ReadLine());
            char[] randomString = Console.ReadLine().ToCharArray();
            int result = 0;

            foreach (char c in randomString)
            {
                if(c > start && c < finish)
                {
                    result += c;
                }
            }

            Console.WriteLine(result);
        }
    }
}