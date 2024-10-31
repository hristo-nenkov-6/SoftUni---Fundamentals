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
            string input = Console.ReadLine();
            char[] arrInp = input.ToCharArray();
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < arrInp.Length; i++)
            {
                int asciiNum = arrInp[i] + 3;
                char newLetter = (char)asciiNum;
                sb.Append(newLetter);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}