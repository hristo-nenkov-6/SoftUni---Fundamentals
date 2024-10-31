using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());
        string maxVolume = "";
        double V = 0;
        for(int i = 0; i < n; i++)
        {
            string keg = Console.ReadLine();
            double radius = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double V1 = Math.PI * Math.Pow(radius, 2) * height;
            if(V1 >= V)
            {
                V = V1;
                maxVolume = keg;
            }
        }
        Console.WriteLine(maxVolume);
    }
}