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
            List<int> list1 = Console.ReadLine()
                                .Split(' ')
                                .Select(int.Parse)
                                .ToList();

            List<int> list2 = Console.ReadLine()
                                .Split(' ')
                                .Select(int.Parse)
                                .ToList();

            List<int> newlist  = new List<int>();

            int iterations = Math.Max(list1.Count, list2.Count);
            for(int  i = 0; i < iterations; i++)
            {
                if(i < list1.Count)
                {
                    newlist.Add(list1[i]);
                }
                if(i < list2.Count)
                {
                    newlist.Add(list2[i]);
                }
            }
            Console.WriteLine(String.Join(" ", newlist));
        }
    }
}