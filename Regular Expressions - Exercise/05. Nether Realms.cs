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
            string[] names = Console.ReadLine().Split(new string[3] { " ", ",", ", "}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var dict = new SortedDictionary<string, double[]>();
            foreach (string n in names)
            {
                //Name
                string name = n;

                //Health
                int health = 0;
                string reg1 = @"[^\+\-\*\/\.0-9]";
                Regex regex1 = new Regex(reg1);
                var matchedLetters = regex1.Matches(name);
                foreach (Match match in matchedLetters)
                {
                    char x = char.Parse(match.ToString());
                    health += x;
                }

                //Damage
                double damage = 0;
                string reg2 = @"-?[0-9]+\.[0-9]+|-?[0-9]+";
                Regex regex2 = new Regex(reg2);
                var matchedNumbers = regex2.Matches(name);
                foreach(Match match in matchedNumbers)
                {
                    double x = double.Parse(match.ToString());
                    damage += x;
                }

                string reg3 = @"[\*\/]";
                Regex regex3 = new Regex(reg3);
                var matchedMultipliers = regex3.Matches(name);
                foreach( Match match in matchedMultipliers)
                {
                    if(match.ToString() == "*")
                    {
                        damage *= 2;
                    }
                    else
                    {
                        damage /= 2;
                    }
                }

                //Add to dict
                dict.Add(name, new double[] { health, damage });
            }
            
            //Output
            foreach(var item in dict)
            {
                Console.WriteLine($"{item.Key} - {item.Value[0]} health, {item.Value[1]:f2} damage");
            }
        }
    }
}