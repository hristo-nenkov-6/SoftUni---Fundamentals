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
            string revWord = Console.ReadLine();
            string input = Console.ReadLine();
            
            while(input.Contains(revWord))
            {
                int ind = input.IndexOf(revWord);
                int lenghtOfWord = revWord.Length;
                input = input.Remove(ind, lenghtOfWord);
            }
            Console.WriteLine(input);
        }
    }
}