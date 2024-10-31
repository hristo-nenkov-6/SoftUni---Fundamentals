using System;
using System.Globalization;
using System.Numerics;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int Snowmax = 0;
        int Timemax = 0;
        int Qualitymax = 0;
        BigInteger Valuemax = 0;
        for (int i = 0; i < n; i++)
        {
            int snowballSnow = int.Parse(Console.ReadLine());
            int snowballTime = int.Parse(Console.ReadLine());
            int snowballQuality = int.Parse(Console.ReadLine());

            BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
            if(snowballValue>=Valuemax)
            {
                Valuemax = snowballValue;
                Snowmax = snowballSnow;
                Timemax = snowballTime;
                Qualitymax = snowballQuality;
            }
        }
        Console.WriteLine($"{Snowmax} : {Timemax} = {Valuemax} ({Qualitymax})");


    }
}