using System;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<Dragon>>();
            List<Dragon> dragons = new List<Dragon>();
            var all = new Dictionary<string, double[]>();

            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                                         .Split(" ")
                                         .ToArray();

                string type = "", name = "";
                int damage, health, armor;

                type = input[0];

                name = input[1];

                if (input[2] != "null")
                {
                    damage = int.Parse(input[2]);
                }
                else
                {
                    damage = 45;
                }

                if (input[3] != "null")
                {
                    health = int.Parse(input[3]);
                }
                else
                {
                    health = 250;
                }

                if (input[4] != "null")
                {
                    armor = int.Parse(input[4]);
                }
                else
                {
                    armor = 10;
                }

                Dragon dragon = new Dragon(type, name, damage, health, armor);
                if(dragons.Any(x => x.Name == dragon.Name && x.Type == dragon.Type))
                {
                    Dragon old = dragons.Find(x => x.Name == dragon.Name && x.Type == dragon.Type);
                    dragons.Insert(dragons.IndexOf(old),dragon);
                    dragons.Remove(old);
                }
                else
                {
                    dragons.Add(dragon);
                }
            }

            foreach(var d in dragons)
            {
                if(!dict.ContainsKey(d.Type))
                {
                    dict.Add(d.Type, new List<Dragon>() { d});
                }
                else
                {
                    dict[d.Type].Add(d);
                }
            }

            foreach(var type in dict)
            {
                double damage = 0, health = 0, armor = 0;
                foreach(var d in dict[type.Key])
                {
                    damage += d.Damage;
                    health += d.Health;
                    armor += d.Armor;
                }
                damage = damage / dict[type.Key].Count;
                health = health / dict[type.Key].Count;
                armor = armor / dict[type.Key].Count;
                all.Add(type.Key, new double[3] {damage, health, armor});
            }

            foreach(var type in all)
            {
                Console.WriteLine($"{type.Key}::({type.Value[0]:f2}/{type.Value[1]:f2}/{type.Value[2]:f2})");
                foreach(var dragon in dict[type.Key].OrderBy(x => x.Name))
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                }
            }
        }
        class Dragon
        {
            public Dragon(string type, string name, int damage, int health, int armor)
            {
                Type = type;
                Name = name;
                Damage = damage;
                Health = health;
                Armor = armor;
            }

            public string Type { get; set; }
            public string Name { get; set; }
            public int Damage { get; set; }
            public int Health { get; set; }
            public int Armor { get; set; }
        }
    }
}