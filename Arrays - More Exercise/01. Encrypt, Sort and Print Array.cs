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
            int lines = int.Parse(Console.ReadLine());
            int[] arrayOfSums = new int[lines];
            for(int i = 0; i < lines; i++)
            {
                string name = Console.ReadLine();
                int sumOfEncrypted = 0;
                for(int j = 0; j < name.Length; j++)
                {
                    char x = name[j];
                    if (x == 'a' || x == 'e' || x == 'i' ||
                            x == 'o' || x == 'u' ||
                            x == 'A' || x == 'E' || x == 'I' ||
                            x == 'O' || x == 'U')
                    {
                        sumOfEncrypted += x * name.Length;
                    }
                    else
                    {
                        sumOfEncrypted += x / name.Length;
                    }
                }
                arrayOfSums[i] = sumOfEncrypted;
            }
            
            for(int i = 0; i < lines; i++)
            {
                for (int k = i + 1; k < arrayOfSums.Length; k++)
                {
                    if (arrayOfSums[i] > arrayOfSums[k])
                    {
                        int t = arrayOfSums[k];
                        arrayOfSums[k] = arrayOfSums[i];
                        arrayOfSums[i] = t;
                    }
                }
            }
            
            for(int k = 0; k < lines; k++)
            {
                Console.WriteLine(arrayOfSums[k]);
            }
        }
    }
}
