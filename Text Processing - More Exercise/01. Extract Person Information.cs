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
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                int indexOfName1 = input.IndexOf('@') + 1;
                int lenght = input.IndexOf('|') - indexOfName1;
                string name = input.Substring(indexOfName1, lenght);

                int indexOfAge1 = input.IndexOf('#') + 1;
                int ageLenght = input.IndexOf('*') - indexOfAge1;
                string age = input.Substring(indexOfAge1, ageLenght);
                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}