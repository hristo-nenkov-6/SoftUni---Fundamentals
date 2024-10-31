using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        char firstChar = char.Parse(Console.ReadLine());
        char secondChar = char.Parse(Console.ReadLine());
        char thirdChar = char.Parse(Console.ReadLine());
        Console.WriteLine($"{thirdChar} {secondChar} { firstChar}");
    }
}