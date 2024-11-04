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
            string input = string.Empty;
            string fullInp = string.Empty;
            List<string> prods = new List<string>();
            string reg = @">>([A-Z][A-Za-z]+)<<(\d+|\d+\.\d+)!(\d+)";
            Regex regex = new Regex(reg);
            double fullPrice = 0;

            while((input = Console.ReadLine()) != "Purchase")
            {
                fullInp += input + "\n";
            }

            var matches = regex.Matches(fullInp);

            foreach(Match match in matches)
            {
                string type = match.Groups[1].Value;
                double price = double.Parse(match.Groups[2].Value);
                int quantity = int.Parse(match.Groups[3].Value);
                fullPrice += price * quantity;
                prods.Add(type);
            }

            Console.WriteLine("Bought furniture:");
            foreach (var product in prods)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine($"Total money spend: {fullPrice:f2}");
        }
    }
}