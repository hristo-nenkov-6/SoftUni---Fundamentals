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
            var arr = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToArray();
            for(int i = 0; i < arr.Length; i++)
            {
                bool isGreater = false;
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] <= arr[j])
                    {
                        isGreater = true;
                        break;
                    }
                }
                if(isGreater == false) 
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
