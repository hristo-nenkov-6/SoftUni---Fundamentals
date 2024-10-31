using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        string town = Console.ReadLine();
        double population = double.Parse(Console.ReadLine());
        float area = float.Parse(Console.ReadLine());

        Console.WriteLine($"Town {town} has population of {population} and area {area} square km.");
    }
}