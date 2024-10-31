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
            int wantednumber = int.Parse(Console.ReadLine()); 
            int[] fibboNumbers = new int[wantednumber];
            Array.Fill(fibboNumbers, 1);
            for(int i = 2; i < wantednumber; i++)
            {
                fibboNumbers[i] = fibboNumbers[i - 1] + fibboNumbers[i - 2];
            }
            Console.WriteLine(fibboNumbers[wantednumber - 1]);
        }
    }
}
