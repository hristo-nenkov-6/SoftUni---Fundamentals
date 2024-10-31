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
            var ar1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var ar2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool notEqual = false;
            int sum = 0;

            for(int i = 0; i < ar1.Length; i++)
            {
                if (!ar1[i].Equals(ar2[i]))
                {
                    Console.WriteLine("Arrays are not identical. Found difference at {0} index", i);
                    notEqual = true;
                }
                else
                {
                    sum += ar1[i];
                }
            }
            if(!notEqual)
            {
                Console.WriteLine("Arrays are identical. Sum: {0}", sum);
            }
        }
    }
}
