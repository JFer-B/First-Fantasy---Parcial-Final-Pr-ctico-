using FIrstFantasyGame.Classes.Equippables;
using FIrstFantasyGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FIrstFantasyGame.Classes.Subject
{
    public abstract class Character : IDescribable
    {
        private string name;
        private string type;
        private int level;
        private int experience;
        private Weapon armament;
        private Armor suit;
        private int life;
        private int mana;
        private List<Weapon> weaponinventory;
        private List<Armor> armorinventory;
        private List<Potion> potioninventory;


        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }
        public int Experience { get => experience; set => experience = value; }
        public string Type { get => type; set => type = value; }
        public Weapon Armament { get => armament; set => armament = value; }
        public int Life { get => life; set => life = value; }
        public int Mana { get => mana; set => mana = value; }
        public Armor Suit { get => suit; set => suit = value; }
        public List<Weapon> WeaponInventory { get => weaponinventory; set => weaponinventory = value; }
        public List<Armor> ArmorInventory { get => armorinventory; set => armorinventory = value; }
        public List<Potion> PotionInventory { get => potioninventory; set => potioninventory = value; }

        public int Attack()
        {
            Random val = new Random();
            int damage_attack = val.Next(1, 8) + Armament.Damage;
            return damage_attack;
        }

        public string ShowInfo()
        {
            string info = this.Name + " (" + this.Type + " Level " + this.Level.ToString() + ")" + "\n\n" + this.Armament.ShowInfo() + "\n\n" + this.Suit.ShowInfo();
            return info;
        }
    }
}
