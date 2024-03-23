using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exercise_05_Football_team_generator
{
    public class Team
    {
        private string name;
        private readonly List<Player> players;

        private Team() 
        {
            this.players = new List<Player>();
        }
        public Team(string name):this()
        {
            Name = name;
        }

        public string Name
        {
            get 
            {
                return this.name;
            }
            set 
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ErrorsForFootballTeam.NameIsEmptyOrNull);
                }
                else 
                {
                    this.name = value;
                }

            }
        }

        public void addPlayer(Player player) 
        {
            this.players.Add(player);
        }

        public void removePlayer(string playerName) 
        {
            Player playerToDelete = this.players.FirstOrDefault(p => p.Name == playerName);

            if (playerToDelete == null)
            {
                throw new ArgumentException(String.Format(ErrorsForFootballTeam.PlayerDoesntExist, playerName,this.Name));
            }
            else 
            {
                this.players.Remove(playerToDelete);
            }
        }

        //AutoCalculated property it has only getter 
        public int Rating 
        {
            get 
            {
                if (this.players.Any())
                {
                    return (int)Math.Round(this.players.Average(p => p.Stats.GetOVerallStat()), 0);
                }
                else 
                {
                    return 0;
                }
            }
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Rating}";
        }




    }
}
