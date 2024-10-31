using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        string user = Console.ReadLine();
        string res = "";
        for(int i = user.Length - 1; i >= 0; i--)
        {
            res += user[i];
        }
        int br = 0;
        while(true)
        {
            string pass = Console.ReadLine();
            if(pass == res)
            {
                Console.WriteLine($"User {user} logged in.");
                break;
            }
            else
            {
                br++;
                if (br == 4)
                {
                    Console.WriteLine($"User {user} blocked!");
                    break;
                }
                Console.WriteLine($"Incorrect password. Try again.");
            }
        }
    }
}