using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int x = a;
        int sum = 0;
        for (int i = 0; i < a.ToString().Length; i++)
        {
            sum += x % 10;
            x =  x / 10;
        }
        Console.WriteLine(sum);
    }
}