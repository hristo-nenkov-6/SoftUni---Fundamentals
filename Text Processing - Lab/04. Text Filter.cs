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
            string[] bannedWords = Console.ReadLine().Split(", ").ToArray();
            string textToFormat = Console.ReadLine();

            foreach(string word in bannedWords)
            {
                int wordLengt = word.Length;
                while(textToFormat.Contains(word))
                {
                    textToFormat = textToFormat.Replace(word, new string('*', wordLengt));
                }
            }

            Console.WriteLine(textToFormat);
        }
    }
}