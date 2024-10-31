using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        //capacity = 255l;
        int capacity = 255;
        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            int liters = int.Parse(Console.ReadLine());
            if (liters <= capacity)
            {
                capacity -= liters;
            }
            else
            {
                Console.WriteLine("Insufficient capacity!");
            }
        }
        Console.WriteLine(255 - capacity);
    }
}