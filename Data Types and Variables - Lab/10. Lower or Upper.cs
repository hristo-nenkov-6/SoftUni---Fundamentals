using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        char a = char.Parse(Console.ReadLine());
        bool x = (a >= 65 && a <= 90);
        if(x == true) { Console.WriteLine("upper-case"); }
        else { Console.WriteLine("lower-case"); }
    }
}