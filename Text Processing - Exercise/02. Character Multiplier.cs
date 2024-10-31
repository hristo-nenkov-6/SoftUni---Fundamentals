using System;
using System.Reflection.Metadata.Ecma335;
using System.Linq;
using System.Text;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string first = input[0];
            string second = input[1];

            int minLenght = Math.Min(first.Length, second.Length);
            for(int i = 0; i < minLenght; i++)
            {
                sum += (char)first[i] * (char)second[i];
            }
            first.Remove(0, minLenght - 1);
            second.Remove(0, minLenght - 1);

            if(first.Length > second.Length)
            {
                for(int i = second.Length; i < first.Length; i++)
                {
                    sum += (char)first[i];
                }
            }

            else if(first.Length < second.Length)
            {
                for (int i = first.Length; i < second.Length; i++)
                {
                    sum += (char)second[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}