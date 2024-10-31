using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        string a = Console.ReadLine();
        string a1 = "";
        for(int i = a.Length - 1; i >= 0; i--)
        {
            a1 += a[i];
        }
        Console.WriteLine(a1);
    }
}