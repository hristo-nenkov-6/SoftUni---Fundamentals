using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        decimal sum = 0;
        for(int i = 1; i <= n; i++)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            sum += a;
        }
        Console.WriteLine(sum);
    }
}