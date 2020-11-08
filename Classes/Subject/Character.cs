using System;
using System.Collections.Generic;
using System.Text;

namespace FIrstFantasyGame.Classes.Subject
{
    public abstract class Character
    {
        private string name;
        private string type;
        private int level;
        private int experience;
        private Weapon armament;
        private int life;
        private int mana;


        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }
        public int Experience { get => experience; set => experience = value; }
        public string Type { get => type; set => type = value; }
        public Weapon Armament { get => armament; set => armament = value; }
        public int Life { get => life; set => life = value; }
        public int Mana { get => mana; set => mana = value; }

        public int Attack(Weapon weapon)
        {
            Random val = new Random();
            int damage_attack = val.Next(1, 8) + weapon.Damage;
            return damage_attack;
        }
    }
}
