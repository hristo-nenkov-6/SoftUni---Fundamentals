using System;
using System.Data;
using System.Net.NetworkInformation;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isEqual = false;
                for (int i = 0; i < arr.Length; i++)
                {
                    int sumLeft = 0, sumRight = 0;
                    for (int leftIndex = 0; leftIndex < i; leftIndex++)
                    {
                        sumRight += arr[leftIndex];
                    }
                    for (int rightIndex = i + 1; rightIndex < arr.Length; rightIndex++)
                    {
                        sumLeft += arr[rightIndex];
                    }
                    if (sumLeft == sumRight)
                    {
                        isEqual = true;
                        Console.WriteLine(i);
                        break;
                    }
                }
            if(!isEqual)
            {
                Console.WriteLine("no");
            }
        }
    }
}
