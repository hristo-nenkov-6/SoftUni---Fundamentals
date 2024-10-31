using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int loss = int.Parse(Console.ReadLine());
        double headprice = double.Parse(Console.ReadLine());
        double mouseprice = double.Parse(Console.ReadLine());
        double keyprice = double.Parse(Console.ReadLine());
        double disprice = double.Parse(Console.ReadLine());

        int head = loss / 2;
        int mouse = loss / 3;
        int key = loss / 6;
        int disp = loss / 12;

        double sum = head * headprice + mouse * mouseprice + key * keyprice + disp * disprice;

        Console.WriteLine($"Rage expenses: {sum:F2} lv.");
    }
}