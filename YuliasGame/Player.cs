using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace YuliasGame
{
    class Player
    {
        private string name;
        private int maxHealth;
        private int health;
        private int strength;
        private int endurance;
        private int experience;
        private int level;

        public Player()
        {
        }

        public void Describe()
        {
            Console.Clear();
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Endurance: {Enduarance}");
            Console.WriteLine($"Experience: {Experience}");
            Console.WriteLine($"Level: {Level}");
        }

        public void TakeDamage(int monsterStrength)
        {
            Health = Health - monsterStrength;
        }

        public int RestoreHealth()
        {
            return Health = MaxHealth;
        }

        public int LevelUpdate()
        {
            return Experience / 100 +1;
        }

        public void StatsUpdate()
        {
            Level = LevelUpdate();
            Health = RestoreHealth();
        }

        public string Name { get => name; set => name = value; }
        public int MaxHealth { get => maxHealth; set => maxHealth = value; }
        public int Health { get => health; set => health = value; }
        public int Strength { get => strength; set => strength = value; }
        public int Enduarance { get => endurance; set => endurance = value; }
        public int Experience { get => experience; set => experience = value; }
        public int Level { get => level; set => level = value; }

    }
}
