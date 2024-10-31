using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        double balance = double.Parse(Console.ReadLine());
        double bal = balance;
        string game = Console.ReadLine();
        while(game != "Game Time")
        {
            double price = 0;
            string name = "";
            switch(game)
            {
                case "OutFall 4":
                    price = 39.99;
                    name = "OutFall 4";
                    break;

                case "CS: OG":
                    price = 15.99;
                    name = "CS: OG";
                    break;

                case "Zplinter Zell":
                    price = 19.99;
                    name = "Zplinter Zell";
                    break;

                case "Honored 2":
                    price = 59.99;
                    name = "Honored 2";
                    break;

                case "RoverWatch":
                    price = 29.99;
                    name = "RoverWatch";
                    break;

                case "RoverWatch Origins Edition":
                    price = 39.99;
                    name = "RoverWatch Origins Edition";
                    break;

                default:
                    Console.WriteLine("Not Found");
                    break;
            }
            if(balance > price && name != "")
            {
                balance -= price;
                Console.WriteLine($"Bought {name}");
            }
            else if(balance == price && name != "")
            {
                balance -= price;
                Console.WriteLine($"Bought {name}");
                Console.WriteLine("Out of money!");
            }
            else if(balance < price && name != "")
            {
                Console.WriteLine("Too Expensive");
            }
            game = Console.ReadLine();
        }
        if (balance != 0)
        {
            Console.WriteLine($"Total spent: ${(bal - balance):F2}. Remaining: ${balance:F2}");

        }
    }
}