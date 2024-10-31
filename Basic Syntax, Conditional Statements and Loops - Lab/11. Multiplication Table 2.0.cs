using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            if (d < 10)
            {
                for (int i = d; i <= 10; i++)
                {
                    Console.WriteLine($"{a} X {i} = {a * i}");
                }
            }
            else
            {
                Console.WriteLine($"{a} X {d} = {a * d}");
            }
        }
    }
}
