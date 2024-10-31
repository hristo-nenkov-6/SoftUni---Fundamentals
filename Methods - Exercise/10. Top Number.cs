using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            for(int i  = 8; i < a; i++)
            {
                TopNumber(i);
            }
        }
        static void TopNumber(int a)
        {
            bool divisable = false;
            bool odd = false;
            int sum = 0;
            int q = a;
            while(a > 0)
            {
                sum += a % 10;
                if((a % 10) % 2 == 1)
                {
                    odd = true;
                }
                a = a / 10;
            }
            if(sum % 8 == 0)
            {
                divisable = true;
            }
            if(divisable && odd) 
            {
                Console.WriteLine(q);
            }
        }
    }
}