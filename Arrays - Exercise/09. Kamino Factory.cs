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
            int lenght = int.Parse(Console.ReadLine());
            int maxSum = 0;
            int[] betterDNA = new int[lenght];
            int bestSample = 0, sample = 0;
            int bestStartIndex = 0; ;
            var arr = Console.ReadLine();
            while (arr != "Clone them!")
            {
                sample++;
                int[] array = arr.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int currentSum = 0;
                int currentStartIndex = -1;
                for (int numberOfArray = 0; numberOfArray < array.Length; numberOfArray++)
                {
                    if (array[numberOfArray] == 1)
                    {
                        currentSum += 1;
                        if (currentSum == 1)
                        {
                            currentStartIndex = numberOfArray;
                        }
                    }
                    else
                    {
                        currentSum = 0;
                    }
                    if (currentSum > maxSum)
                    {
                        betterDNA = array;
                        maxSum = currentSum;
                        bestSample = sample;
                        bestStartIndex = currentStartIndex;
                    }
                    else if (currentSum == maxSum && currentStartIndex < bestStartIndex)
                    {
                        betterDNA = array;
                        maxSum = currentSum;
                        bestSample = sample;
                        bestStartIndex = currentStartIndex;
                    }
                    else if (currentSum == maxSum &&
                        currentStartIndex == bestStartIndex &&
                        Enumerable.Sum(betterDNA) < Enumerable.Sum(array))
                    {
                        betterDNA = array;
                        maxSum = currentSum;
                        bestSample = sample;
                        bestStartIndex = currentStartIndex;
                    }
                }
                arr = Console.ReadLine();
                if (Enumerable.Sum(betterDNA) == 0)
                {
                    bestSample = 1;
                }
            }
            Console.WriteLine($"Best DNA sample {bestSample} with sum: {Enumerable.Sum(betterDNA)}.");
            Console.WriteLine(String.Join(" ", betterDNA));
        }
    }
}
