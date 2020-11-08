using FIrstFantasyGame.Classes.Subject;
using FIrstFantasyGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FIrstFantasyGame.Classes
{
    public abstract class Weapon : IStorable
    {
        private string type;
        private string name;
        private int damage;
        private string range;
        private string rarity;

        public string Type { get => type; set => type = value; }
        public int Damage { get => damage; set => damage = value; }
        public string Range { get => range; set => range = value; }
        public string Rarity { get => rarity; set => rarity = value; }
        public string Name { get => name; set => name = value; }

        public double Sell()
        {
            double price = 5000;
            switch (this.Rarity)
            {
                case "Common":
                    price = price * 1;
                    break;
                case "Uncommon":
                    price = price * 1.5;
                    break;
                case "Rare":
                    price = price * 2;
                    break;
                case "Epic":
                    price = price * 3;
                    break;
                case "Legendary":
                    price = price * 5;
                    break;
            }
            return price;
        }
    }
}
