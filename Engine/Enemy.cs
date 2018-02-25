﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Enemy : Creature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardCurrency { get; set; }
        public List<LootItem> LootTable { get; set; }

        public Enemy(int id, string name, int maximumDamage, int rewardExperiencePoints, int rewardCurrency, int currentHitPoints, int maximumHitPoints) : base(currentHitPoints, maximumHitPoints)
        {
            ID = id;
            Name = name;
            MaximumDamage = maximumDamage;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardCurrency = rewardCurrency;
            LootTable = new List<LootItem>();
        }
    }
}
