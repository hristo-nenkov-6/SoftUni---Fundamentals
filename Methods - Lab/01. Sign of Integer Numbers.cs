using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            Console.Write($"The number {s} is ");
            Check(s);
        }
        static void Check(int number)
        {
            if(number > 0) 
            {
                Console.WriteLine("positive.");
            }
            else if(number < 0)
            {
                Console.WriteLine("negative.");
            }
            else { Console.WriteLine("zero."); }
        }
    }
}
