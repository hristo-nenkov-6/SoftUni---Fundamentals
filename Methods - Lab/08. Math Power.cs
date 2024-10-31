using System;
using System.Runtime.CompilerServices;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine()); ;
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(Power(input, a));
        }
        static double Power(double num, int power)
        {
            return Math.Pow(num, power);
        }
    }
}
