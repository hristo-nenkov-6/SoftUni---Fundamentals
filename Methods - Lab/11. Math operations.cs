using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            char @operator = char.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(a,@operator, b));
        } 
        private static double Calculate(double a, char @operator, double b)
        {
            switch (@operator)
            {
                case '+':
                    return a + b; 
                    break;
                case '-':
                    return a - b;
                    break;
                case '*':
                    return a * b;
                    break;
                case '/':
                    return a / b;
                    break;
                default:
                    return 0;
                    break;
            }
        }
    }
}