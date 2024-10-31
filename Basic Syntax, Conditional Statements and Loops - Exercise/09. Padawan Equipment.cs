using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        double money = double.Parse(Console.ReadLine());
        int count = int.Parse(Console.ReadLine());
        double lightsaber = double.Parse(Console.ReadLine());
        double robe = double.Parse(Console.ReadLine());
        double belt = double.Parse(Console.ReadLine());

        double sum = 0;
        sum += (Math.Ceiling(count * 1.1) * lightsaber) + robe * count + belt * (count - (count / 6));

        if (money >= sum)
        {
            Console.WriteLine($"The money is enough - it would cost {sum:F2}lv.");
        }
        else
        {
            Console.WriteLine($"John will need {(sum - money):F2}lv more.");
        }
    }
}