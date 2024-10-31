using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            string input = string.Empty;
            var dict = new Dictionary<string, Dictionary<string, int>>();
            var fullSkill = new Dictionary<string, int>();

            while((input = Console.ReadLine()) != "Season end")
            {
                string[] splitArr  = input.Split(" -> ").ToArray();
                if(splitArr.Length > 1)
                {
                    string name = splitArr[0];
                    string position = splitArr[1];
                    int skill = int.Parse(splitArr[2]);

                    if(dict.ContainsKey(name))
                    {
                        if (dict[name].ContainsKey(position))
                        {
                            if (dict[name][position] < skill)
                            {
                                dict[name][position] = skill;
                            }
                        }
                        else
                        {
                            dict[name].Add(position, skill);
                        }
                    }
                    else
                    {
                        dict.Add(name, new Dictionary<string, int>() { [position] = skill });
                    }
                
                }
                else
                {
                    string[] splitVS = input.Split(" vs ").ToArray();
                    string player1 = splitVS[0];
                    string player2 = splitVS[1];

                    if (dict.ContainsKey(player1) && dict.ContainsKey(player2))
                    {

                        bool haveEqualElements = false;
                        foreach (string position in dict[player1].Keys)
                        {
                            if (dict[player2].ContainsKey(position))
                            {
                                haveEqualElements = true;
                                break;
                            }
                        }

                            if(haveEqualElements)
                            {
                                int p1 = dict[player1].Values.Sum();
                                int p2 = dict[player2].Values.Sum();

                                if(p1 > p2)
                                {
                                    dict.Remove(player2);
                                }
                                else if(p1 < p2)
                                {
                                    dict.Remove(player1);
                                }
                            }
                    }
                }
            }

            foreach(var name in dict.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{name.Key}: {name.Value.Values.Sum()} skill");
                foreach (var position in dict[name.Key].OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }
    }
}