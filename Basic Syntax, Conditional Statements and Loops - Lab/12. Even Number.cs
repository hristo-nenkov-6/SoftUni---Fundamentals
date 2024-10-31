using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            while(true)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine("The number is: " + Math.Abs(a));
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                    a = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
