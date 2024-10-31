using System;
using System.Data;
using System.Net.NetworkInformation;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel.DataAnnotations;

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
            int rotations = int.Parse(Console.ReadLine()); 
            for(int i  = 0; i < rotations; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    int oldarr = arr[j+1];
                    arr[j+1] = arr[j];
                    arr[j] = oldarr;
                }
            }
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
