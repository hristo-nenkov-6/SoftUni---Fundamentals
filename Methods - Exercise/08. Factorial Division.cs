using System;
using System.Diagnostics.CodeAnalysis;
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
            Console.WriteLine($"{(double)(Factorial(a) / Factorial(b)):f2}");
        }
        static double Factorial(int x)
        {
            double multi = 1;
            if (x > 0)
            {
                for (int j = x; j > 0; j--)
                {
                    multi = multi * j;
                }
                return multi;
            }
            else if(x == 0)
            {
                return 1; 
            }
            else
            {
                for (int j = x; j < 0; j++)
                {
                    multi = multi * j;
                }
                return multi;
            }
        }
    }
}