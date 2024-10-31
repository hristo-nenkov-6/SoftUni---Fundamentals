using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        double V = 0;
        Console.Write("Length: ");
        double lenght = double.Parse(Console.ReadLine());
        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        double height = double.Parse(Console.ReadLine());
        V = (lenght * width * height) / 3;
        Console.WriteLine($"Pyramid Volume: {V:f2}");
    }
}