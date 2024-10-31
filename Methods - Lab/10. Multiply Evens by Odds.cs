using System;
using System.Runtime.CompilerServices;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            MultipliedSums(a);
        }
        static int SumOfOdd(int a)
        {
            int sum = 0;
            while (a != 0)
            {
                if (Math.Abs(a % 10) % 2 == 1)
                {
                    sum += Math.Abs(a % 10);
                }
                a = a / 10;
            }
            return sum;
        }
        static int SumOfEven(int a)
        {
            int sum = 0;
            while(a != 0)
            {
                if (Math.Abs(a % 10) % 2 == 0)
                {
                    sum += Math.Abs(a % 10);
                }
                a = a / 10;
            }
            return sum;
        }
        static void MultipliedSums(int a)
        {
            Console.WriteLine(SumOfEven(a) * SumOfOdd(a));
        }
    }
}
