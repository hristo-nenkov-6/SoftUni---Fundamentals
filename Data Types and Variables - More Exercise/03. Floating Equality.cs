using System;
using System.Globalization;
using System.Numerics;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        bool x = false;
        if(Math.Abs(Math.Abs(a) - Math.Abs(b)) < 0.000001)
        {
            x = true;
        }
        Console.WriteLine(x);
    }
}