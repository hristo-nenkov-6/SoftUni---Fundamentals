using System;
using System.Data;
using System.Net.NetworkInformation;
using System.Linq;
using System.Runtime.InteropServices;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.
                        ReadLine().
                        Split(' ').
                        Select(int.Parse).
                        ToArray();
            int sum = 0;
            foreach(var item in arr)
            {
                if(item % 2 == 0)
                {
                    sum += item;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
