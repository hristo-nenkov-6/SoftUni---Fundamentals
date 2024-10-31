using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int meters = int.Parse(Console.ReadLine());
        float kilometers = meters / 1000.0f;
        Console.WriteLine($"{kilometers:f2}");
    }
}