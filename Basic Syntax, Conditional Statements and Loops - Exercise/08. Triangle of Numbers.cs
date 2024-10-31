using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        for(int i = 1; i <= a; i++)
        {
            for(int j = 0; j < i; j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}