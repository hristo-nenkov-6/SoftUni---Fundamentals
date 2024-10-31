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
            int wagons = int.Parse(Console.ReadLine());
            int[] arr = new int[wagons];
            int sum = 0;
            for(int i = 0; i < wagons; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }
            Console.WriteLine(String.Join(" ", arr));
            Console.WriteLine(sum);
        }
    }
}
