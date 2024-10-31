using System;
using System.Globalization;
using System.Numerics;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int countLines = int.Parse(Console.ReadLine());
        int br1 = 0;
        for(int i = 0; i < countLines; i++)
        {
            string x = Console.ReadLine();
            if (x == "(") br1++;
            else if (x == ")") br1--;
            if (br1 < 0) break;
        }
        if (br1 == 0) Console.WriteLine("BALANCED");
        else
        {
            Console.WriteLine("UNBALANCED");
        }
    }
}