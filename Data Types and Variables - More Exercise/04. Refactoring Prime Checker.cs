using System;
using System.Globalization;
using System.Numerics;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        for (int i = 2; i <= count; i++)
        {
            bool isTrue = true;
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    isTrue = false;
                    break;
                }
            }
            Console.WriteLine("{0} -> {1}", i, isTrue.ToString().ToLower());
        }
    }
}