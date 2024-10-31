using System;
using System.Collections.Generic;
using System.Linq;
 
namespace TeamworkProjects
{
    class Team
    {
        public string TeamCreator { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get; set; } = new List<string>();
 
        public Team(string teamCreator, string teamName)
        {
            TeamCreator = teamCreator;
            TeamName = teamName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());
 
            List<Team> teams = new List<Team>();
            string input = string.Empty;
 
            for (int i = 0; i < numberOfTeams; i++)
            {
                input = Console.ReadLine();
                string[] cmd = input.Split('-');
                bool isTeamNameFree = true;
                bool isGreatorNameFree = true;
                Team currTeam = new Team(cmd[0], cmd[1]);
 
                foreach (Team item in teams)
                {
                    if (item.TeamCreator.Contains(cmd[0]))
                    {
                        isGreatorNameFree = false;
                        break;
                    }
                    else if (item.TeamName.Contains(cmd[1]))
                    {
                        isTeamNameFree = false;
                        break;
                    }
                }
 
                if (isTeamNameFree == true && isGreatorNameFree == true || teams.Count == 0)
                {
                    teams.Add(currTeam);
                    Console.WriteLine($"Team {currTeam.TeamName} has been created by {currTeam.TeamCreator}!");
                }
                else if (isTeamNameFree == false) Console.WriteLine($"Team {currTeam.TeamName} was already created!");
                else if (isGreatorNameFree == false) Console.WriteLine($"{currTeam.TeamCreator} cannot create another team!");
            }
 
            input = Console.ReadLine();
 
            while (input != "end of assignment")
            {
                string[] cmd = input.Split("->");
                bool isMember = false;
                bool isTeamCreated = false;
 
                foreach (Team item in teams)
                {
                    if (item.Members.Contains(cmd[0]) || item.TeamCreator.Contains(cmd[0]))
                    {
                        isMember = true;
                    }
 
                    if (item.TeamName.Contains(cmd[1]))
                    {
                        isTeamCreated = true;
                    }
                }
 
                if (isTeamCreated == false) Console.WriteLine($"Team {cmd[1]} does not exist!");
                if (isMember == true) Console.WriteLine($"Member {cmd[0]} cannot join team {cmd[1]}!");
                if (isTeamCreated == true && isMember == false)
                {
                    for (int i = 0; i < teams.Count; i++)
                    {
                        if (teams[i].TeamName == cmd[1]) teams[i].Members.Add(cmd[0]);
                    }
                }
 
                input = Console.ReadLine();
            }
 
            List<Team> validTeam = new List<Team>();
            List<Team> disbandTeam = new List<Team>();
 
            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i].Members.Count == 0)
                {
                    disbandTeam.Add(teams[i]);
                }
                else
                {
                    validTeam.Add(teams[i]);
                }
            }
 
            foreach (Team item in validTeam.OrderByDescending(x => x.Members.Count).ThenBy(x => x.TeamName))
            {
                Console.WriteLine(item.TeamName);
                Console.WriteLine($"- {item.TeamCreator}");
                foreach (string member in item.Members.OrderBy(member => member))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
 
            Console.WriteLine("Teams to disband:");
 
            if (disbandTeam != null)
            {
                foreach (Team item in disbandTeam.OrderBy(x => x.TeamName))
                {
                    Console.WriteLine(item.TeamName);
                }
            }
        }
    }
}
