using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        string type = Console.ReadLine();
        string day = Console.ReadLine();
        double price = 0;

        if(day == "Friday")
        {
            if(type == "Students")
            {
                price = 8.45;
            }
            else if(type == "Business")
            {
                price = 10.90;
            }
            else
            {
                price = 15;
            }
        }
        else if (day == "Saturday")
        {
            if (type == "Students")
            {
                price = 9.80;
            }
            else if (type == "Business")
            {
                price = 15.60;
            }
            else
            {
                price = 20;
            }
        }
        else if (day == "Sunday")
        {
            if (type == "Students")
            {
                price = 10.46;
            }
            else if (type == "Business")
            {
                price = 16;
            }
            else
            {
                price = 22.50;
            }
        }
        double total = price * count;
        if(type == "Students" && count >= 30)
        {
            total = total * 0.85;
        }
        else if (type == "Business" && count >= 100)
        {
            total = price * (count - 10);
        }
        else if(type == "Regular" && count >= 10 && count <= 20)
        {
            total = total * 0.9;
        }
        
        Console.WriteLine($"Total price: {total:F2}");
    }
}