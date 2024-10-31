using System;
using System.Data;
using System.Net.NetworkInformation;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Reflection.Metadata;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int[] previousArray = new int[height];
            for(int i  = 0; i < height; i++)
            {
                previousArray[i] = 1;
            }
            for(int i  = 1; i <= height; i++)
            {
                int[] arr = new int[i];
                for(int j = 0; j < i; j++)
                {
                    if(j == 0 || j == i - 1)
                    {
                        arr[j] = 1;
                    }
                    else
                    {
                        arr[j] = previousArray[j-1] + previousArray[j];
                    }
                }
                Console.WriteLine(String.Join(" ", arr));
                previousArray = arr;
            }
        }
    }
}
