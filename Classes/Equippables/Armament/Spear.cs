using System;
using System.Collections.Generic;
using System.Text;

namespace FIrstFantasyGame.Classes.Equippables.Armament
{
    public class Spear : Weapon
    {
        public Spear(string name, string rarity)
        {
            this.Name = name;
            this.Rarity = rarity;
            this.Type = "Spear";
            this.Range = "Long";
            Random val = new Random();
            switch (rarity)
            {
                case "Common":
                    this.Damage = val.Next(1, 10);
                    break;
                case "Uncommon":
                    this.Damage = val.Next(11, 25);
                    break;
                case "Rare":
                    this.Damage = val.Next(26, 50);
                    break;
                case "Epic":
                    this.Damage = val.Next(51, 80);
                    break;
                case "Legendary":
                    this.Damage = val.Next(81, 120);
                    break;
            }
        }
    }
}
