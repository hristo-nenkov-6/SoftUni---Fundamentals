using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            TakeMiddleChar(str);
        } 
        static void TakeMiddleChar(string a)
        {
            if(a.Length % 2 == 1)
            {
                Console.WriteLine(a[a.Length / 2]);
            }
            else
            {
                Console.Write(a[a.Length / 2 - 1]);
                Console.WriteLine(a[a.Length / 2]);
            }
        }
    }
}