using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i <= 2 * n; i = i + 2)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.Write("Sum: " + sum);
        }
    }
}
