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
            string regex = @"%([A-Z][a-z]+)%[^\|\$\%\.]*<(\w+)>[^\|\$\%\.]*\|(\d+)\|[^\|\$\%\.1-9]*(\d+\.\d+|\d+)\$";
            var dict = new Dictionary<string, Dictionary<string, double>>();
            string input = string.Empty;
            double totalInc = 0;
            while((input = Console.ReadLine()) != "end of shift")
            {
                Regex inp = new Regex(regex);
                var matchedItems = inp.Match(input);
                if(matchedItems.Groups.Count == 1)
                {
                    continue;
                }

                string name = matchedItems.Groups[1].Value;
                string product = matchedItems.Groups[2].Value;
                double quantity = double.Parse(matchedItems.Groups[3].Value);
                double price = double.Parse(matchedItems.Groups[4].Value);
                
                double money = price * quantity;
                Console.WriteLine($"{name}: {product} - {money:f2}");
                totalInc += money;
            }
            Console.WriteLine($"Total income: {totalInc:f2}");
        }
    }
}
/*
%InvalidName%<Croissant>|2|10.3$
%Peter%<Gum>1.3$
%Maria%<Cola>|1|2.4
%Valid%<Valid>valid|10|valid20$
end of shift

 */