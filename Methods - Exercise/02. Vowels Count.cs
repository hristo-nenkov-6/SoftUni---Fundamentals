using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            if (a > b)
            {
                char t = a;
                a = b;
                b = t;
            }
            PrintChars(a, b);     
        } 
        static void PrintChars(char a, char b)
        {
            for(int i = a + 1; i < b; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}