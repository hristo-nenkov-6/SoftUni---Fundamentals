using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for(int i = 1; i <= n; i++)
        {
            int sumofdigits = 0;
            int digits = i;
            while(digits > 0)
            {
                sumofdigits += digits % 10;
                digits /= 10;
            }
            bool special = (sumofdigits == 5 || sumofdigits == 7 || sumofdigits == 11);
            Console.WriteLine($"{i} -> {special}");
        }
    }
}