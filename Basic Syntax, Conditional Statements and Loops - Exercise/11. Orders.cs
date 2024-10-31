using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int broi = int.Parse(Console.ReadLine());
        double sum = 0;
        for(int i = 1; i <= broi; i++)
        {
            double price = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());

            sum += price * days * count;
            Console.WriteLine($"The price for the coffee is: ${(price * days * count):F2}");
        }
        Console.WriteLine($"Total: ${sum:F2}");
    }
}