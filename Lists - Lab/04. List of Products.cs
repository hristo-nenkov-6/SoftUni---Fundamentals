using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for(int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine());
            }

            list.Sort();
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(i+1 + "." + list[i]);
            }
        }
    }
}