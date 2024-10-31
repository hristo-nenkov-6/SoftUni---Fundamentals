using System;
using System.Globalization;
using System.Numerics;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int key = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        string decrypted = "";

        for(int i = 0; i < n; i++)
        {
            char a = char.Parse(Console.ReadLine());
            int b = (int)a + key;
            decrypted += (char)b;
        }
        Console.WriteLine(decrypted);
    }
}