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
            StringBuilder sb = new StringBuilder(Console.ReadLine());
            StringBuilder newSB = new StringBuilder();
            ushort multiplier = ushort.Parse(Console.ReadLine());
            int remider = 0;

            if (multiplier > 0)
            {
                for (int i = sb.Length - 1; i >= 0; i--)
                {
                    string digit = sb[i].ToString();
                    int newDigit = ushort.Parse(digit) * multiplier;
                    newDigit += remider;

                    if (newDigit >= 10)
                    {
                        int secondDigit = newDigit % 10;
                        int firstDigit = newDigit / 10;

                        if (i == 0)
                        {
                            int final = newDigit;
                            newSB.Insert(0, final.ToString());
                        }
                        else
                        {
                            newSB.Insert(0, secondDigit.ToString());
                            remider = firstDigit;
                        }
                    }
                    else
                    {
                        if (i == sb.Length - 1)
                        {
                            newSB.Append(newDigit.ToString());
                            remider = 0;
                        }
                        else
                        {
                            newSB.Insert(0, newDigit.ToString());
                            remider = 0;
                        }
                    }
                }
            Console.WriteLine(newSB.ToString());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}