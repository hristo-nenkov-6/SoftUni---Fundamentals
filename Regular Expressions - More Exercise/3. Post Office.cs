using System;
using System.Reflection.Metadata.Ecma335;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\b(?<Day>\d{2})([-.\/])(?<Month>[A-Z][a-z]{2})\1(?<Year>\d{4})\b";
            var datesString = Console.ReadLine();
            var dates = Regex.Matches(datesString, regex);

            foreach(Match date in dates)
            {
                var day = date.Groups["Day"].Value;
                var month = date.Groups["Month"].Value;
                var year = date.Groups["Year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
/*
 * 13/Jul/1928, 10-Nov-1934, , 01/Jan-1951,f 25.Dec.1937 23/09/1973, 1/Feb/2016
 */