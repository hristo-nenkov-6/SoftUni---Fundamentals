using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            while ((a = Console.ReadLine()) != "END")
            {
                Console.WriteLine(IsPalindrome(a));
            }
        }
        static string IsPalindrome(string x)
        {
            bool a = true;
            for(int i = 0; i < x.Length / 2; i++)
            {
                if (x[i] != x[x.Length - 1 - i])
                {
                    a = false;
                    break;
                }
            }
            if (a)
            {
                return "true";
            }
            else
            {  return "false"; }
        }
    }
}