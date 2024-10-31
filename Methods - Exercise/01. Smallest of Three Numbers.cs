using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()); 
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Min(a, b, c);
        } 
        
        static void Min(int a, int b, int c)
        { 
            int x = Math.Min(a, b);
            Console.WriteLine(Math.Min(x, c));
        }

    }
}