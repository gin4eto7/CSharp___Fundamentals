using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            int teamNum = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < teamNum; i++)
            {
                string createCommand = Console.ReadLine();
                string[] creatorTeam = createCommand.Split("-");
                string creatorName = creatorTeam[0];
                string teamName = creatorTeam[1];

                if (teams.Any(x => x.CreatorName == creatorName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                else if (teams.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                    continue;
                }
                Team team = new Team(creatorName, teamName);
                teams.Add(team);

            }

            while (true)
            {
                string joinedCommand = Console.ReadLine();

                if (joinedCommand == "end of assignment")
                {
                    break;
                }


                string[] joinToTeam = joinedCommand.Split("->");
                string creatorName = joinToTeam[0];
                string teamName = joinToTeam[1];

                if(!teams.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                if(teams.Any(x => x.nameJoined.Contains(creatorName) || x.CreatorName == creatorName))
                {
                    Console.WriteLine($"Member {creatorName} cannot join team {teamName}!");
                }

                int index = teams.FindIndex(x => x.TeamName == teamName);
                teams[index].nameJoined.Add(creatorName);
            }

            var disbandTeam = teams.OrderBy(x => x.TeamName).Where(x => x.nameJoined.Count == 0);
            var totalTeams = teams.OrderByDescending(x => x.nameJoined.Count).ThenBy(x => x.TeamName).Where(x => x.nameJoined.Count > 0);

            foreach (var team in totalTeams)
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.CreatorName}");

                foreach (var join in team.nameJoined.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {join}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var item in disbandTeam)
            {
                Console.WriteLine(item.TeamName);
            }
        }
    }

    public class Team
    {
        public string CreatorName { get; set; }

        public string TeamName { get; set; }

        public List<string> nameJoined;

        public Team(string creatorName, string teamName)
        {
            this.CreatorName = creatorName;
            this.TeamName = teamName;

            nameJoined = new List<string>();

        }
    }
}
