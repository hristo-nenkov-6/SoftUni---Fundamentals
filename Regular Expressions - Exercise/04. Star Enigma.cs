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
            var attacked = new List<string>();
            var destroyed = new List<string>();

            int n = int.Parse(Console.ReadLine());
            string reg = @"[^\@\-\!\:\>]*@[^\@\-\!\:\>A-Za-z]*([A-Za-z]+)[^\@\-\!\:\>A-Za-z]*:[^\@\-\!\:\>1-9]*(\d+)[^\@\-\!\:\>1-9]*![^\@\-\!\:\>]*(A|D)[^\@\-\!\:\>]*![^\@\-\!\:\>]*->[^\@\-\!\:\>1-9]*(\d+)[^\@\-\!\:\>]*\b";
            Regex regex = new Regex(reg);

            for (int i = 0; i < n; i++)
            {
                int count = 0;
                char[] input = Console.ReadLine().ToCharArray();
                string decrypted = string.Empty;

                foreach(char c in input)
                {
                    char x = char.ToLower(c);
                    if(x == 's' || x == 't' || x == 'a' || x == 'r')
                    {
                        count++;
                    }
                }

                foreach (char remCount in input)
                {
                    char x = remCount;
                    x = (char)(x - count);
                    decrypted += x;
                }

                var matchedItem = regex.Match(decrypted);
                if (matchedItem != null)
                {
                    if (matchedItem.Groups[3].Value == "A")
                    {
                        string name = matchedItem.Groups[1].Value;
                        attacked.Add(name);
                    }
                    else if (matchedItem.Groups[3].Value == "D")
                    {
                        string name = matchedItem.Groups[1].Value;
                        destroyed.Add(name);
                    }
                }
            }
            Console.WriteLine("Attacked planets: " +  attacked.Count);
            foreach(string planet in attacked.OrderBy(a => a))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine("Destroyed planets: " + destroyed.Count);
            foreach (string planet in destroyed.OrderBy(a => a))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}