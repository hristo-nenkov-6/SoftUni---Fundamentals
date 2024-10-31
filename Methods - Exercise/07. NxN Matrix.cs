using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Methods
{
    class Program
    {
        static int br = 0;
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Row(a);
        }
        static void Row(int a)
        {
            for(int i = 0; i < a; i++)
            {
                for(int j = 0; j < a; j++)
                {
                    Console.Write(a + " ");
                }
                Console.WriteLine();
            }    
        }
    }
}