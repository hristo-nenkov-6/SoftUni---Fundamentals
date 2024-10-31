using System;
using System.Data;
using System.Net.NetworkInformation;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
           // int br = 0;
            int[] arr1 = new int[num];
            int[] arr2 = new int[num];
            for (int i = 0; i < num; i++)
            {
                var arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                arr1[i] = arr[i % 2];
                arr2[i] = arr[(i+1)%2]; 
            }
            Console.WriteLine(String.Join(" ", arr1));
            Console.WriteLine(String.Join(" ", arr2));
        }
    }
}
