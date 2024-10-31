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
            var arr = Console.ReadLine().
                         Split(" ").
                         Select(int.Parse).
                         ToArray();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] str = input.
                         Split(" ").
                         ToArray();
                if (str[0] == "exchange")
                {
                    if (int.Parse(str[1]) < 0 || int.Parse(str[1]) > arr.Length)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        arr = Exchange(arr, int.Parse(str[1]));
                    }
                }
                else if (str[0] == "max")
                {
                    if (str[1] == "even")
                    {
                        MaxEven(arr);
                    }
                    else if (str[1] == "odd")
                    {
                        MaxOdd(arr);
                    }
                }
                else if (str[0] == "min")
                {
                    if (str[1] == "even")
                    {
                        MinEven(arr);
                    }
                    else if (str[1] == "odd")
                    {
                        MinOdd(arr);
                    }
                }
                else if (str[0] == "first")
                {
                    if (int.Parse(str[1]) > arr.Length - 1)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        if (str[2] == "even")
                        {
                            FirstEven(arr, int.Parse(str[1]));
                        }
                        else if (str[2] == "odd")
                        {
                            FirstOdd(arr, int.Parse(str[1]));
                        }
                    }
                }
                else if (str[0] == "last")
                {
                    if (int.Parse(str[1]) > arr.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else 
                    {
                        if (str[2] == "even")
                        {
                            LastEven(arr, int.Parse(str[1]));
                        }
                        else if (str[2] == "odd")
                        {
                            LastOdd(arr, int.Parse(str[1]));
                        }
                    }
                }
            }
            Console.Write("[");
            for(int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine(arr[arr.Length - 1] + "]");
        }

        static int[] Exchange(int[] arr, int indexAfter)
        {
            int br = 0;
            int[] newarr = new int[arr.Length];
            for (int i = indexAfter + 1; i < arr.Length; i++)
            {
                newarr[br] = arr[i];
                br++;
            }
            for (int i = 0; i <= indexAfter; i++)
            {
                newarr[br] = arr[i];
                br++;
            }
            return newarr;
        }

        static void MaxEven(int[] arr)
        {
            int maxIndex = -1;
            int maxNum = -1;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    if (arr[i] >= maxNum)
                    {
                        maxIndex = i;
                        maxNum = arr[i];
                    }
                }
            }
            if (maxIndex == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxIndex);
            }
        }

        static void MaxOdd(int[] arr)
        {
            int maxIndex = -1;
            int maxNum = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    if (arr[i] >= maxNum)
                    {
                        maxIndex = i;
                        maxNum = arr[i];
                    }
                }
            }
            if (maxIndex == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxIndex);
            }
        }

        static void MinEven(int[] arr)
        {
            int minNum = int.MaxValue;
            int minIndex = -1;         
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    if (arr[i] <= minNum)
                    {
                        minIndex = i;
                        minNum = arr[i];
                    }
                }
            }
            if (minNum == int.MaxValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(minIndex);
            }
        }

        static void MinOdd(int[] arr)
        {
            int minNum = int.MaxValue;
            int minIndex = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    if (arr[i] < minNum)
                    {
                        minIndex = i;
                        minNum = arr[i];
                    }
                }
            }
            if (minNum == int.MaxValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(minIndex);
            }
        }

        static void FirstEven(int[] arr, int digits)
        {
            int br = 0;
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && br > 0)
                {
                    Console.Write(", ");
                }
                if (arr[i] % 2 == 0)
                {
                    Console.Write(arr[i]);
                    br++;
                }
                if (br == digits)
                {
                    break;
                }
            }
            Console.WriteLine("]");
        }        

        static void FirstOdd(int[] arr, int digits)
        {
            int br = 0;
            Console.Write("[");
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1 && br > 0)
                {
                    Console.Write(", ");
                }
                if (arr[i] % 2 == 1)
                {
                    Console.Write(arr[i]);
                    br++;
                }
                if(br == digits)
                {
                    break;
                }
            }
            Console.WriteLine("]");
        }

        static void LastEven(int[] arr, int digits)
        {
            int[] newarr = new int[digits];
            int br = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] % 2 == 0)
                {
                    newarr[br] = arr[i];
                    br++;
                }
                if (br == digits)
                {
                    break;
                }
            }
            Console.Write("[");
            for (int i = br - 1; i > 0; i--)
            {
                Console.Write(newarr[i] + ", ");
            }
            if (br > 0)
            {
                Console.WriteLine(newarr[0] + "]");
            }
            else { Console.WriteLine("]"); }
        }

        static void LastOdd(int[] arr, int digits)
        {
            int[] newarr = new int[digits];
            int br = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] % 2 == 1)
                {
                    newarr[br] = arr[i];
                    br++;
                }
                if (br == digits)
                {
                    break;
                }
            }
            Console.Write("[");
            for (int i = br - 1; i > 0; i--)
            {
                Console.Write(newarr[i] + ", ");
            }
            if (br > 0)
            {
                Console.WriteLine(newarr[0] + "]");
            }
            else { Console.WriteLine("]"); }
        }
    }
}