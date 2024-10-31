using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());
        int Y = int.Parse(Console.ReadLine());
        int targets = 0;
        int N1 = N;

        while(N >= M)
        {
            N -= M;
            targets++;
            if(N * 2 == N1)
            {
                if(N >= Y && Y > 0)
                {
                    N /= Y;
                }
            }
        }

        Console.WriteLine(N);
        Console.Write(targets);
    }
}