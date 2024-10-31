using System;
using System.Globalization;
using System.Numerics;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        for(int i = 0; i < count; i++)
        {
            string h = Console.ReadLine();
            int j = 0;
            string a1 = "", b1 = "";
            while(!h[j].Equals(' '))
            {
                a1 = a1 + h[j];
                j++;
            }
            j++;
            while(j < h.Length)
            {
                b1 = b1 + h[j];
                j++;
            }

            long a = long.Parse(a1);
            long b = long.Parse(b1);

            if (a > b)
            {
                long sum = 0;
                a = Math.Abs(a);
                while(a > 0)
                {
                    sum += a % 10;
                    a /= 10;
                }
                Console.WriteLine(sum);
            }
            else
            {
                long sum = 0;
                b = Math.Abs(b);
                while (b > 0)
                {
                    sum += b % 10;
                    b /= 10;
                }
                Console.WriteLine(sum);
            }
        }
    }
}