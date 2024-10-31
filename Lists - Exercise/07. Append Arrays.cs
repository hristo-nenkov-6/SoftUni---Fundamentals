using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                                    .Split(" ")
                                    .Select (int.Parse)
                                    .ToList ();

            string input = string.Empty;
            bool changed = false;

            while((input = Console.ReadLine()) != "end")
            {
                string[] splittedInput = input.Split(' ').ToArray();
                switch(splittedInput[0])
                {
                    case "Add":
                        {
                            changed = true;
                            list.Add(int.Parse(splittedInput[1]));
                            break;
                        }

                    case "Remove":
                        {
                            changed = true;
                            list.Remove(int.Parse(splittedInput[1]));
                            break;
                        }

                    case "RemoveAt":
                        {
                            changed = true;
                            list.RemoveAt(int.Parse(splittedInput[1]));
                            break;
                        }

                    case "Insert":
                        {
                            changed = true;
                            list.Insert(int.Parse(splittedInput[2]), int.Parse(splittedInput[1]));
                            break;
                        }
                    case "Contains":
                        {
                            if (list.Contains(int.Parse(splittedInput[1])))
                            {
                                Console.WriteLine("Yes");
                            }
                            else
                            {
                                Console.WriteLine("No such number");
                            }
                            break;
                        }

                    case "PrintEven":
                        {
                            List<int> evenNums = new List<int>();
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i] % 2 == 0)
                                {
                                    evenNums.Add(list[i]);
                                }
                            }
                            Console.WriteLine(String.Join(" ", evenNums));
                            break;
                        }

                    case "PrintOdd":
                        {
                            List<int> oddNums = new List<int>();
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i] % 2 == 1)
                                {
                                    oddNums.Add(list[i]);
                                }
                            }
                            Console.WriteLine(String.Join(" ", oddNums));
                            break;
                        }

                    case "GetSum":
                        {
                            int sumOfAll = 0;
                            for(int i = 0; i < list.Count(); i++)
                            {
                                sumOfAll += list[i];
                            }
                            Console.WriteLine(sumOfAll);
                            break;
                        }

                    case "Filter":
                        {
                            switch (splittedInput[1])
                            {
                                case "<":
                                    {
                                        List<int> newlist = new List<int>();
                                        for (int i = 0; i < list.Count; i++)
                                        {
                                            if (list[i] < int.Parse(splittedInput[2]))
                                            {
                                                newlist.Add(list[i]);
                                            }
                                        }
                                        Console.WriteLine(String.Join(" ", newlist));
                                        break;
                                    }

                                case ">":
                                    {
                                        List<int> newlist = new List<int>();
                                        for (int i = 0; i < list.Count; i++)
                                        {
                                            if (list[i] > int.Parse(splittedInput[2]))
                                            {
                                                newlist.Add(list[i]);
                                            }
                                        }
                                        Console.WriteLine(String.Join(" ", newlist));
                                        break;
                                    }

                                case ">=":
                                    {
                                        List<int> newlist = new List<int>();
                                        for (int i = 0; i < list.Count; i++)
                                        {
                                            if (list[i] >= int.Parse(splittedInput[2]))
                                            {
                                                newlist.Add(list[i]);
                                            }
                                        }
                                        Console.WriteLine(String.Join(" ", newlist));
                                        break;
                                    }

                                case "<=":
                                    {
                                        List<int> newlist = new List<int>();
                                        for (int i = 0; i < list.Count; i++)
                                        {
                                            if (list[i] <= int.Parse(splittedInput[2]))
                                            {
                                                newlist.Add(list[i]);
                                            }
                                        }
                                        Console.WriteLine(String.Join(" ", newlist));
                                        break;
                                    }
                            }
                            break;
                        }
                }
            }
            if(changed)
            {
                Console.WriteLine(String.Join(" ", list));
            }
        }
    }
}