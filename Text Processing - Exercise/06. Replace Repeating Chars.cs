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
            StringBuilder sb = new StringBuilder(Console.ReadLine());
            StringBuilder sb2 = new StringBuilder();

            char previousChar = sb[0];
            sb2.Append(previousChar);
            for(int i = 1; i < sb.Length; i++)
            {
                if (!previousChar.Equals(sb[i]))
                {
                    sb2.Append(sb[i]);
                    previousChar = sb[i];
                }
            }
            Console.WriteLine(sb2.ToString());
        }
    }
}