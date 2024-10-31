using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            switch(order)
            {
                case "water":
                    Total(1.00, quantity);
                    break;
                case "coffee":
                    Total(1.50, quantity);
                    break;
                case "coke":
                    Total(1.40, quantity);
                    break;
                case "snacks":
                    Total(2.00, quantity);
                    break;
            }
        }
        static void Total(double price, int quantity)
        {
            Console.WriteLine($"{(price * quantity):f2}");
        }
    }
}
