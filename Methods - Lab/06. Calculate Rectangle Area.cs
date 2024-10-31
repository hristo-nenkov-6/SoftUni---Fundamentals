using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(Area(a, b));
        }
        static double Area(double lenght, double height)
        {
           return lenght * height;
        }
    }
}
