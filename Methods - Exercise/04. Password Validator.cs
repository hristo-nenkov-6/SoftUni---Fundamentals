using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            for(int i = 1; i < a; i++) 
            {
                PrintLine(1, i);
            }
            for (int i = a; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }
        static void PrintLine(int start, int end)
        {
            for(int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
