using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int sum = 0;
        for(int i = 0; i < a; i++)
        {
            char x = char.Parse(Console.ReadLine());
            sum += x;
        }
        Console.WriteLine("The sum equals: " + sum);
    }
}