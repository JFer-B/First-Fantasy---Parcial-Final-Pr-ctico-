using FIrstFantasyGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FIrstFantasyGame.Classes.Equippables
{
    public class Armor : IStorable, IDescribable
    {
        private string name;
        private int defense;
        private string rarity;

        public string Name { get => name; set => name = value; }
        public int Defense { get => defense; set => defense = value; }
        public string Rarity { get => rarity; set => rarity = value; }

        public Armor(string name, string rarity)
        {
            this.Name = name;
            this.Rarity = rarity;
            Random val = new Random();
            switch (rarity)
            {
                case "Common":
                    this.Defense = val.Next(50, 100);
                    break;
                case "Uncommon":
                    this.Defense = val.Next(101, 150);
                    break;
                case "Rare":
                    this.Defense = val.Next(151, 250);
                    break;
                case "Epic":
                    this.Defense = val.Next(251, 350);
                    break;
                case "Legendary":
                    this.Defense = val.Next(351, 500);
                    break;
            }
        }

        public double Sell()
        {
            double price = 10000;
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

        public string ShowInfo()
        {
            string info = this.Name + " (" + this.Rarity + ")" + "\n" + "Defense: " + this.Defense.ToString();
            return info;
        }
    }
}
