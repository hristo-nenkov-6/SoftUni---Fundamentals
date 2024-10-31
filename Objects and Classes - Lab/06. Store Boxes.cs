using System.ComponentModel;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> inBox = new List<Box>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] arrayInput = input.Split(' ').ToArray();

                string serialNumber = arrayInput[0];
                string itemName = arrayInput[1];
                int itemQuantity = int.Parse(arrayInput[2]);
                double itemPrice = double.Parse(arrayInput[3]);

                double boxPrice = itemQuantity * itemPrice;

                Item item = new Item(itemName, itemPrice);
                Box box = new Box(serialNumber, item, itemQuantity,boxPrice);

                inBox.Add(box);
            }

           inBox = inBox.OrderByDescending(box => box.BoxPrice).ToList();

            foreach (Box box in inBox)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Item_Quantity}");
                Console.WriteLine($"-- ${box.BoxPrice:f2}");
            }
        }
        class Item
        {
            public Item(string name, double price)
            {
                Name = name;
                Price = price;
            }
            public string Name { get; set; }
            public double Price { get; set; }
        }

        class Box
        {
            public Box(string serialNumber, Item item, int item_Quantity, double boxPrice)
            {
                SerialNumber = serialNumber;
                Item = item;
                Item_Quantity = item_Quantity;
                BoxPrice = boxPrice;
            }

            public string SerialNumber { get; set; }
            public Item Item { get; set; }
            public int Item_Quantity { get; set; }
            public double BoxPrice { get; set; }

        }
    }

}