using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        char firstCharacter = char.Parse(Console.ReadLine());
        char secondCharacter = char.Parse(Console.ReadLine());
        char thirdCharacter = char.Parse(Console.ReadLine());

        Console.WriteLine(firstCharacter.ToString() + secondCharacter.ToString() + thirdCharacter.ToString());
    }
}