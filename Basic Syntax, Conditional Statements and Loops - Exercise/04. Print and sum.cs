using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int finish = int.Parse(Console.ReadLine());
        int sum = 0;

        for(int i = start; i <= finish; i++)
        {
            sum += i;
            Console.Write(i + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Sum: " + sum);
    }
}