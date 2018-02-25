using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : Creature
    {
        public int Currency { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }

        public Player(int currentHitPoints, int maximumHitPoints, int currency, int experiencePoints, int level) : base(currentHitPoints, maximumHitPoints)
        {
            Currency = currency;
            ExperiencePoints = experiencePoints;
            Level = level;
        }
    }
}
