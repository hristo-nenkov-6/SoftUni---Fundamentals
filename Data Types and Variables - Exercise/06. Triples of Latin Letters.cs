using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        for(int i = 97; i < 97 + a; i++)
        {
            for (int j = 97; j < 97 + a; j++)
            {
                for (int h = 97; h < 97 + a; h++)
                {
                    Console.WriteLine($"{((char)i)}{((char)j)}{((char)h)}");
                }
            }
        }
    }
}