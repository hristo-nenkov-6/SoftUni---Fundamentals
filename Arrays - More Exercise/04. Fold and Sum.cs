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
            var arr = Console.ReadLine()
                            .Split(" ")
                            .Select(int.Parse)
                            .ToArray();
            int lenghtOfArrays = arr.Length / 2;
            int[] upperArrLeft = new int[lenghtOfArrays / 2];
            int[] upperArrRight = new int[lenghtOfArrays / 2];
            int[] lowerArr = new int[lenghtOfArrays];
            int[] upperArr = new int[lenghtOfArrays];
            for (int i = 0; i < lenghtOfArrays / 2; i++)
            {
                upperArrLeft[i] = arr[lenghtOfArrays/2 - 1 - i];
            }
            for (int i = 0; i < lenghtOfArrays / 2; i++)
            {
                upperArrRight[lenghtOfArrays / 2 - 1 - i] = arr[i + lenghtOfArrays / 2 + lenghtOfArrays];
            }
            for(int i = 0;i < lenghtOfArrays / 2;i++ )
            {
                upperArr[i] = upperArrLeft[i];
            }
            for(int i = lenghtOfArrays / 2;i < lenghtOfArrays;i++ )
            {
                upperArr[i] = upperArrRight[i - lenghtOfArrays / 2];
            }
            for(int i = lenghtOfArrays / 2; i < lenghtOfArrays + lenghtOfArrays / 2; i++)
            {
                lowerArr[i - lenghtOfArrays / 2] = arr[i];
            }
            
            for(int i = 0; i < lenghtOfArrays; i++)
            {
                Console.Write((upperArr[i] + lowerArr[i]) + " ");
            }
        }
    }
}
