using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Dwarf> dwarfs = new List<Dwarf>();
            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] inp = input.Split(" <:> ").ToArray();
                string name = inp[0];
                string hatColor = inp[1];
                long physics = long.Parse(inp[2]);

                if (dwarfs.Any(x => x.Name == name))
                {
                    if (dwarfs.Any(x => x.HatColor == hatColor))
                    {
                        Dwarf d = dwarfs.Find(x => x.Name == name && x.HatColor == hatColor);
                        if(d != null)
                        {
                            if (d.Physics < physics)
                            {
                                d.Physics = physics;
                            }
                        }
                        else
                        {
                            Dwarf dwarf = new Dwarf(name, hatColor, physics);
                            dwarfs.Add(dwarf);
                        }
                    }
                    else
                    {
                        Dwarf dwarf = new Dwarf(name, hatColor, physics);
                        dwarfs.Add(dwarf);
                    }
                }
                else
                {
                    Dwarf dwarf = new Dwarf(name, hatColor, physics);
                    dwarfs.Add(dwarf);
                }
            }

            Dictionary<string, int> hatColorCount = new Dictionary<string, int>();
            foreach (Dwarf d in dwarfs)
            {
                string color = d.HatColor;
                if (!hatColorCount.ContainsKey(color))
                {
                    hatColorCount.Add(color, 1);
                }
                else
                {
                    hatColorCount[color]++;
                }
            }

            List<Dwarf> sortedDwarfs = new List<Dwarf>();
            foreach (var color in hatColorCount.OrderByDescending(x => x.Value))
            {
                foreach (Dwarf dwarf in dwarfs)
                {
                    if (dwarf.HatColor == color.Key)
                    {
                        sortedDwarfs.Add(dwarf);
                    }
                }
            }

            foreach (var dwarf in sortedDwarfs.OrderByDescending(x => x.Physics).ThenByDescending(x => hatColorCount.Values))
            {
                Console.WriteLine($"({dwarf.HatColor}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }
        class Dwarf
        {
            public Dwarf(string name, string hatcolor, long physics)
            {
                Name = name;
                HatColor = hatcolor;
                Physics = physics;
            }

            public string Name { get; set; }
            public string HatColor { get; set; }
            public long Physics { get; set; }
            public int br = 0;
        }

    }
}