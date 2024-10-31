using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            min = min + 30;
            if(min > 59)
            {
                min = min - 60;
                hours++;
                if(hours == 24) { hours = 0; }
                Console.WriteLine($"{hours}:{min:D2}");
            }
            else
            {
                Console.WriteLine($"{hours}:{min}");
            }
        }
    }
}
