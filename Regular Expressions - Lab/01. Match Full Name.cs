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
            string regex = @"\b(?<FirstName>[A-Z][a-z]{1,}) (?<LastName>[A-Z][a-z]{1,})\b";
            string input = Console.ReadLine();
            MatchCollection matchedNames = Regex.Matches(input, regex);
            foreach (Match match in matchedNames)
            {
                Console.Write(match.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
/*
 * Bethany Taylor, Oliver miller, sophia Johnson, SARah Wilson, John Smith, Sam          Smith
 */