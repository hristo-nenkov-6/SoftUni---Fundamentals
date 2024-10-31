using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            Dictionary<string, Dictionary<string, int>> conts = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> dict = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] inp = input.Split(" -> ").ToArray();
                string name = inp[0];
                string contest = inp[1];
                int points = int.Parse(inp[2]);

                if (!conts.ContainsKey(contest))
                {
                    conts.Add(contest, new Dictionary<string, int>() { [name] = points }); ;
                }
                else
                {
                    if (conts[contest].ContainsKey(name))
                    {
                        if (conts[contest][name] < points)
                        {
                            dict[name] = dict[name] + points - conts[contest][name];
                            conts[contest][name] = points;
                        }
                        continue;
                    }
                    else
                    {
                        conts[contest].Add(name, points);
                    }
                }

                if(dict.ContainsKey(name))
                {
                    dict[name] += points;
                }
                else
                {
                    dict.Add(name, points);
                }
            }

            foreach (var contest in conts)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
                int x = 1;
                foreach (var user in contest.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{x}. {user.Key} <::> {user.Value}");
                    x++;
                }
            }

            int i = 1;
            Console.WriteLine("Individual standings:");
            foreach (var user in dict.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{i}. {user.Key} -> {user.Value}");
                i++;
            }

        }
    }
}