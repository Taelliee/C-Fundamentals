using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teamsList = new List<Team>();
            InitialiseTeams(teamsList);
            JoinMembers(teamsList);

            List<Team> teamsWithMemebers = teamsList
                .Where(x => x.Members.Count > 0)
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.TeamName)
                .ToList();

            List<Team> teamsToDisband = teamsList
                .Where(x => x.Members.Count == 0)
                .OrderBy(x => x.TeamName)
                .ToList();

            foreach (Team team in teamsWithMemebers)
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.Creator}");
                foreach (string member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (Team disbandedTeam in teamsToDisband)
            {
                Console.WriteLine(disbandedTeam.TeamName);
            }
        }

        static void JoinMembers(List<Team> teamsList)
        {
            string input;
            while ((input = Console.ReadLine()) != "end of assignment")
            {
                string[] command = input
                .Split("->", StringSplitOptions.RemoveEmptyEntries);

                string user = command[0];
                string teamName = command[1];

                if (!TeamAlreadyExists(teamsList, teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (IsAlreadyAMember(teamsList, user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    Team teamToJoin = teamsList
                        .First(x => teamName == x.TeamName);
                    teamToJoin.AddMember(user);
                }
            }
        }

        static void InitialiseTeams(List<Team> teamsList)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                .Split("-", StringSplitOptions.RemoveEmptyEntries);

                string creator = input[0];
                string teamName = input[1];

                if (TeamAlreadyExists(teamsList, teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (IsAlreadyACreator(teamsList, creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team currTeam = new Team(creator, teamName);
                    teamsList.Add(currTeam);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }
        }
        static bool TeamAlreadyExists(List<Team> teamsList, string teamName)
        {
            return teamsList.Any(x => x.TeamName == teamName);
        }
        static bool IsAlreadyACreator(List<Team> teamsList, string creator)
        {
            return teamsList.Any(x => x.Creator == creator);
        }
        static bool IsAlreadyAMember(List<Team> teamsList, string user)
        {
            return teamsList.Any((x => x.Members.Contains(user)))
                || teamsList.Any((x => x.Creator.Contains(user)));
        }
    }
    class Team
    {
        public Team(string creator, string teamName)
        {
            Creator = creator;
            TeamName = teamName;
            Members = new List<string>();
        }

        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }

        public void AddMember(string user)
        {
            this.Members.Add(user);
        }
    }
}
