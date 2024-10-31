using System;
using System.Runtime.CompilerServices;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            if (type == "int")
            {
                Console.WriteLine(GetMax(int.Parse(a), int.Parse(b)));
            }
            else if(type == "char")
            {
                Console.WriteLine(GetMax(char.Parse(a), char.Parse(b)));
            }
            else if(type == "string")
            {
                Console.WriteLine(GetMax(a, b));
            }
        }
        static int GetMax(int first, int second)
        {
            return Math.Max(first, second);
        }
        static char GetMax(char first, char second)
        {
            return (char)Math.Max(first, second);
        }
        static string GetMax(string first, string second)
        {
            int comparison = first.CompareTo(second);
            if (comparison > 0)
            {
                return first;
            }
            else { return second; }
        }
    }
}
