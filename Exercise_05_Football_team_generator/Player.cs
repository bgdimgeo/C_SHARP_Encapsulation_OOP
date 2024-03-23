using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_05_Football_team_generator
{
    public class Player
    {
  
        private string name;


        public Player(string name, Stats stats)
        {
            this.Name = name;
            this.Stats = stats;

        }

        public string Name 
        {
            get 
            {
                return name;
            }
            private set 
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
        public Stats Stats { get; private set; }




    }
}
