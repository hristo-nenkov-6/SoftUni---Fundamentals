using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        string delimiter = Console.ReadLine();
        string result = firstName + delimiter + lastName;
        Console.WriteLine(result);
    }
}