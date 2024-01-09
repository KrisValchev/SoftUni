using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FootballTeamGenerator
{
    public class Player
    {
        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble=dribble;
            Passing = passing;
            Shooting = shooting;
        }
        private string name;

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("A name should not be empty.");
                name = value;
            }
        }
        private int endurance;
        private int sprint;
        private int passing;
        private int shooting;
        private int dribble;

        public int Dribble
        {
            get { return dribble; }
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"{nameof(Dribble)} should be between 0 and 100.");
                }
                dribble = value;
            }
        }


        public int Shooting
        {
            get
            {
                return shooting;
            }
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"{nameof(Shooting)} should be between 0 and 100.");
                }
                shooting = value;
            }
        }
        public int Passing
        {
            get
            {
                return passing;
            }
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"{nameof(Passing)} should be between 0 and 100.");
                }
                passing = value;
            }
        }
        public int Sprint
        {
            get
            {
                return sprint;
            }
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"{nameof(Sprint)} should be between 0 and 100.");
                }
                sprint = value;
            }
        }
        public int Endurance
        {
            get
            {
                return endurance;
            }
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"{nameof(Endurance)} should be between 0 and 100.");
                }
                endurance = value;
            }
        }
        public double SkillLevel()
        {
            return (Endurance + Shooting +Passing + Sprint + Dribble) / 5.0;
        }
    }
}
