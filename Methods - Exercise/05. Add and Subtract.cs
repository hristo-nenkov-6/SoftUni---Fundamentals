using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Methods
{
    class Program
    {
        static bool isValid = true;
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            
            Console.WriteLine(SubstrOfTwoAndThree(a, b, c));
        } 
        static int SumOfFirstTwo(int a, int b)
        {
            return a + b;
        }
        static int SubstrOfTwoAndThree(int a, int b, int c)
        {
            return (SumOfFirstTwo(a, b) - c);
        }
    }
}