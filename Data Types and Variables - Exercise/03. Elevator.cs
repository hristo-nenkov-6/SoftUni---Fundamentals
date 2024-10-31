using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double p = int.Parse(Console.ReadLine());

        Console.WriteLine(Math.Ceiling((n / p)));
    }
}