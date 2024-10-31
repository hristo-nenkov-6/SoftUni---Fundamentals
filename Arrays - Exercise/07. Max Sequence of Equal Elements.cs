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
            int currentSquenceBr = 1, currentSequenceNum = arr[arr.Length-1];
            int maxSquenceBr = 1, maxSequenceNum = arr[0];
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                if (arr[i] == arr[i+1])
                {
                    currentSquenceBr++;
                    currentSequenceNum = arr[i];
                }
                else
                {
                    currentSquenceBr = 1;
                }
                if(currentSquenceBr >= maxSquenceBr)
                {
                    maxSequenceNum = currentSequenceNum;
                    maxSquenceBr = currentSquenceBr;
                }
            }
            for(int i = 0; i < maxSquenceBr; i++)
            {
                Console.Write(maxSequenceNum + " ");
            }
            Console.WriteLine();
        }
    }
}
