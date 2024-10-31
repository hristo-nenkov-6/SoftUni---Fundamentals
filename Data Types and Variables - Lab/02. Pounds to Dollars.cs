using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        double pound = double.Parse(Console.ReadLine());
        double dollar = pound * 1.31;
        Console.WriteLine($"{dollar:f3}");
    }
}