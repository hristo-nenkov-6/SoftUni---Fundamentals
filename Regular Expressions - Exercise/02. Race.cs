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
            string[] participants = Console.ReadLine().Split(", ").ToArray();
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (string participant in participants)
            {
                dict.Add(participant, 0);
            }

            string regex1 = @"[A-Za-z]";
            string regex2 = @"\d";

            Regex reg1 = new Regex(regex1);
            Regex reg2 = new Regex(regex2);

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end of race")
            {
                var letterMatches = reg1.Matches(input);
                var numberMatches = reg2.Matches(input);

                string name = string.Empty;
                int kilometers = 0;

                foreach (var letterMatch in letterMatches)
                {
                    name += letterMatch;
                }

                foreach (var numberMatch in numberMatches)
                {
                    kilometers += int.Parse(numberMatch.ToString());
                }

                if (dict.ContainsKey(name))
                {
                    dict[name] += kilometers;
                }
            }

            int br = 1;
            foreach(var participant in dict.OrderByDescending(x => x.Value))
            {
                if(br == 1)
                {
                    Console.WriteLine($"1st place: {participant.Key}");
                }
                else if (br == 2)
                {
                    Console.WriteLine($"2nd place: {participant.Key}");
                }
                else
                {
                    Console.WriteLine($"3rd place: {participant.Key}");
                    break;
                }
                br++;
            }
        }
    }
}