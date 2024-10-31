using System.Numerics;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger factorial = 1;
            int a = int.Parse(Console.ReadLine());

            for(int i  = 1; i <= a; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }

}