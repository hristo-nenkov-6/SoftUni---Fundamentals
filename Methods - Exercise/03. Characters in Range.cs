using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Methods
{
    class Program
    {
        static bool isValid = true;
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            CheckPassLenght(password);
            CheckPassConsistancy(password);
            CheckPassDigitsNumber(password);      
            IsValid();
        
        } 
        static void CheckPassLenght(string pass)
        {
            if(pass.Length < 6 || pass.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }
        }
        static void CheckPassConsistancy(string pass)
        {
            for(int i  = 0; i < pass.Length; i++)
            {
                if (!(pass[i] >= 'a' && pass[i] <= 'z') &&
                    !(pass[i] >= 'A' && pass[i] <= 'Z') &&
                    !(pass[i] >= '0' && pass[i] <= '9'))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    isValid = false;
                    break;
                }
            }
        }
        static void CheckPassDigitsNumber(string pass)
        {
            int br = 0;
            for (int i = 0; i < pass.Length; i++)
            {
                if ((pass[i] >= '0' && pass[i] <= '9'))
                {
                    br++;
                }
            }
            if(br < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
            }
        }
        static void IsValid()
        {
            if(isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}