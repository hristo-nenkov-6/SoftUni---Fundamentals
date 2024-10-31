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
            double[] nums = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
            int[] roundedNumber = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                roundedNumber[i] = (int)Math.Round(nums[i], MidpointRounding.AwayFromZero);
            }

            for(int i = 0; i < roundedNumber.Length; i++)
            {
                Console.WriteLine("{0} => {1}", nums[i], roundedNumber[i]);
            }
        }
    }
}
