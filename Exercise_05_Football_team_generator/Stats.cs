using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_05_Football_team_generator
{
    public class Stats
    {
        private const int MINSTAT = 0;
        private const int MAXSTAT = 100;

        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Stats(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public int Endurance
        {
            get
            {
                return this.endurance;
            }
            private set
            {

                if (value < 0 || value > 100)
                {
                    throw new ArgumentException(String.Format(ErrorsForFootballTeam.StatError, nameof(this.Endurance)));
                }
                else
                {
                    this.endurance = value;
                }
            }
        }
        public int Sprint
        {
            get
            {
                return this.sprint;
            }
            private set
            {

                if (value < 0 || value > 100)
                {
                    throw new ArgumentException(String.Format(ErrorsForFootballTeam.StatError, nameof(this.Sprint)));
                }
                else
                {
                    this.sprint = value;
                }
            }
        }
        public int Dribble
        {
            get
            {
                return this.dribble;
            }
            private set
            {

                if (value < 0 || value > 100)
                {
                    throw new ArgumentException(String.Format(ErrorsForFootballTeam.StatError, nameof(this.Dribble)));
                }
                else
                {
                    this.dribble = value;
                }
            }
        }
        public int Passing
        {
            get
            {
                return this.passing;
            }
            private set
            {

                if (value < 0 || value > 100)
                {
                    throw new ArgumentException(String.Format(ErrorsForFootballTeam.StatError, nameof(this.Passing)));
                }
                else
                {
                    this.passing = value;
                }
            }
        }
        public int Shooting
        {
            get
            {
                return this.shooting;
            }
            private set
            {

                if (value < 0 || value > 100)
                {
                    throw new ArgumentException(String.Format(ErrorsForFootballTeam.StatError, nameof(this.Shooting)));
                }
                else
                {
                    this.shooting = value;
                }
            }
        }


        public double GetOVerallStat() => (this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / 5.0;

    }
}
