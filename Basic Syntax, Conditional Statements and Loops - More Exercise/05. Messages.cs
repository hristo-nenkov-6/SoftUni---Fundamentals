using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int times = int.Parse(Console.ReadLine());
        string word = "";
        for(int i = 0; i < times; i++)
        {
            int num = int.Parse(Console.ReadLine());
            int num1 = num;
            if (num != 0)
            {
                int digits = 1;
                while (num >= 10)
                {
                    num = num / 10;
                    digits++;
                }
                int offset = (num - 2) * 3;
                if (num == 8 || num == 9)
                {
                    offset++;
                }
                int index = offset + digits - 1;
                char x = (char)(index + 97);
                word += x;
            }
            else
            {
                word += " ";
            }
        }
        Console.WriteLine(word);
    }
}