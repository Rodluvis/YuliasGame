using System;
using System.Collections.Generic;
using System.Text;

namespace YuliasGame
{
    class Monster
    {
        Random random = new Random();

        string[] names = new string[] { "Smilodon", "Tsuchigumo", "Chupacabra", "Griffin", "Chimera", "Kishi" };
        private string name;
        private int health;
        private int strength;
        private int exp;

        public Monster()
        {
            Name = names[random.Next(names.Length)];
            Strength = random.Next(20, 50);
            Health = random.Next(50, 150);
            Experience = random.Next(75, 150);
        }

        public string Name { get => name; set => name = value; }
        public int Health { get => health; set => health = value; }
        public int Strength { get => strength; set => strength = value; }
        public int Experience { get => exp; set => exp = value; }

        public void TakeDamage(int playerStrength)
        {
            Health = Health - playerStrength;
        }

    }

}
