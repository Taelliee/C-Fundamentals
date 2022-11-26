using System;
using System.Collections.Generic;

namespace _05._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Team> teamsList = new List<Team>();

            while (true)
            {
                string[] input = Console.ReadLine()
                .Split("-", StringSplitOptions.RemoveEmptyEntries);

                string user = input[0];
                string teamName = input[1];

                if (user == "end")
                {
                    break;
                }
                if (true)
                {

                }


                Team currTeam = new Team(user, teamName);
                teamsList.Add(currTeam);
            }


        }
    }
    class Team
    {
        public Team(string teamName, string creator)
        {
            TeamName = teamName;
            Creator = creator;
        }

        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }

        public void CreatingTeam(string user, string teamName)
        {
            Console.WriteLine($"Team {teamName} has been created by {user}!");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
