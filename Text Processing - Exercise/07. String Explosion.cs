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
            string[] input = Console.ReadLine().Split(">", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string result = "";
            int previous = 0;

            foreach(string word in input)
            {
                if (char.IsLetter(word[0]) && previous == 0)
                {
                    result += word;
                }
                else if(char.IsLetter(word[0]) && previous > 0)
                {
                    int explosion = previous;
                    string newString = word.Substring(explosion);
                    result+= newString;
                }
                else if (char.IsDigit(word[0]) && word.Length > 1)
                {
                    int explosion = int.Parse(word[0].ToString());
                    explosion += previous;
                    if(explosion <= word.Length)
                    {
                        string newWord = '>' + word.Substring(explosion);

                        previous = previous - explosion;
                        if(previous < 0)
                        {
                            previous = 0;
                        }

                        result += newWord;
                    }
                    else
                    {
                        result += '>';
                        previous += (explosion - word.Length);
                    }
                }
                else if(char.IsDigit(word[0]) && word.Length == 1)
                {
                    if (int.Parse(word[0].ToString()) > 1)
                    {
                        previous += int.Parse(word[0].ToString()) - 1;
                    }
                    result += '>';
                }
            }

            Console.WriteLine(result);
        }
    }
}