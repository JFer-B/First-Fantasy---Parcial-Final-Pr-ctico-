using FIrstFantasyGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FIrstFantasyGame.Classes.Equippables
{
    public class Potion : IStorable
    {
        private string name;
        private int value;
        private string type;

        public string Name { get => name; set => name = value; }
        public int Value { get => value; set => this.value = value; }
        public string Type { get => type; set => type = value; }

        public Potion(string type)
        {
            this.Value = 100;
            this.Type = type;
            this.Name = type + "'s Potion";
        }

        public double Sell()
        {
            double price = 0;
            switch (this.Type)
            {
                case "Health":
                    price = 2000;
                    break;
                case "Mana":
                    price = 1500;
                    break;
                case "Defense":
                    price = 1000;
                    break;
            }
            return price;
        }
    }
}
