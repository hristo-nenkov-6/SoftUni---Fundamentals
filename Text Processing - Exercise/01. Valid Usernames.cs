using System;
using System.Reflection.Metadata.Ecma335;
using System.Linq;
using System.Text;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();
            List<string> valid = new List<string>();
            foreach(string word in  input)
            {
                if(word.Length >= 3 && word.Length <= 16)
                {
                    char[] charInp = word.ToCharArray();
                    bool invalid = false;
                    foreach(char c in charInp)
                    {
                        if(!(char.IsDigit(c) || char.IsLetter(c) || c.Equals('-') || c.Equals('_')))
                        {
                            invalid = true;
                            break;
                        }
                    }
                    if (invalid == false)
                    {
                        valid.Add(word);
                    }
                }
            }

            foreach(string word in valid)
            {
                Console.WriteLine(word);
            }
        }
    }
}