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
            string input = Console.ReadLine();
            string regex = @"\+359(-| )2\1\d{3}\1\d{4}\b";
            var phoneMathces = Regex.Matches(input, regex)
                                     .Cast<Match>()
                                     .Select(a => a.Value.Trim())
                                     .ToArray();

            Console.Write(String.Join(", ", phoneMathces));
        }
    }
}
/*
 * +359 2 222 2222,359-2-222-2222, +359/2/222/2222, +359-2 222 2222 +359 2-222-2222, +359-2-222-222, +359-2-222-22222, +359-2-222-2222

 */