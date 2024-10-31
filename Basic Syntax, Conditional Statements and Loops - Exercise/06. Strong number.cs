using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        string a = Console.ReadLine();
        int a1 = int.Parse(a);
        int sum = 0;
        for(int i = 0; i < a.Length; i++)
        {
            int suma = 1;
            int curr = (int)Char.GetNumericValue(a[i]);
            for (int j = curr; j >= 1; j--)
            {
                suma = suma * j;
            }
            sum = sum + suma;
        }
        if(sum == a1) { Console.WriteLine("yes"); }
        else
        {
            Console.WriteLine("no");
        }
    }
}