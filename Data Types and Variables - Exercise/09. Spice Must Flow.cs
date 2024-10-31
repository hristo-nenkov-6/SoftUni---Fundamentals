using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int startingYield = int.Parse(Console.ReadLine());
        int days = 0;
        int totalYield = 0;
        while(startingYield >= 100)
        {
            days++;
            totalYield += startingYield - 26;
            startingYield -= 10;
        }
        if (totalYield >= 26)
        {
            totalYield -= 26;
        }
        else
        {
            totalYield = 0;
        }
        Console.WriteLine(days);
        Console.Write(totalYield);
    }
}