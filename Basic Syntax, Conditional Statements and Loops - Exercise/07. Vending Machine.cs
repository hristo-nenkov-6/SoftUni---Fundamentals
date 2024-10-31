using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        double pusnati = 0;
        string a = Console.ReadLine();
        while(a != "Start")
        {
            double a1 = double.Parse(a);
            if(a1 == 0.1 || a1 == 0.2 || a1 == 0.5 || a1 == 1 || a1 == 2)
            {
                pusnati += a1;
            }
            else
            {
                Console.WriteLine($"Cannot accept {a1}");
            }
            a = Console.ReadLine();
        }

        double cena = 0;
        string prod = Console.ReadLine();
        while(prod != "End")
        {
            switch(prod)
            {
                case "Nuts":
                    cena = 2.0;
                    if (pusnati >= cena)
                    {
                        pusnati -= cena;
                        Console.WriteLine("Purchased nuts");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    break;

                case "Water":
                    cena = 0.7;
                    if (pusnati >= cena)
                    {
                        pusnati -= cena;
                        Console.WriteLine("Purchased water");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    break;

                case "Crisps":
                    cena = 1.5;
                    if (pusnati >= cena)
                    {
                        pusnati -= cena;
                        Console.WriteLine("Purchased crisps");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    break;

                case "Soda":
                    cena = 0.8;
                    if (pusnati >= cena)
                    {
                        pusnati -= cena;
                        Console.WriteLine("Purchased soda");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    break;

                case "Coke":
                    cena = 1.0;
                    if (pusnati >= cena)
                    {
                        pusnati -= cena;
                        Console.WriteLine("Purchased coke");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid product");
                    break;
            }
            prod = Console.ReadLine();
        }
        Console.WriteLine($"Change: {pusnati:F2}");
    }
}