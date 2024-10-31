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
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sumOdd = 0, sumEven = 0;
            foreach (var item in arr)
            {
                if(item % 2 == 0)
                {
                    sumEven+=item;
                }
                else if(item % 2 == 1)
                {
                    sumOdd+=item;
                }
            }
            Console.WriteLine(sumEven - sumOdd);
        }
    }
}
