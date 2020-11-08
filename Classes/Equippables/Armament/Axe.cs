using System;
using System.Collections.Generic;
using System.Text;

namespace FIrstFantasyGame.Classes.Equippables.Armament
{
    public class Axe : Weapon
    {
        public Axe(string name, string rarity)
        {
            this.Name = name;
            this.Type = "Axe";
            this.Range = "Medium";
            Random val = new Random();
            switch (rarity)
            {
                case "Common":
                    this.Damage = val.Next(10, 25);
                    break;
                case "Uncommon":
                    this.Damage = val.Next(26, 50);
                    break;
                case "Rare":
                    this.Damage = val.Next(51, 80);
                    break;
                case "Epic":
                    this.Damage = val.Next(81, 120);
                    break;
                case "Legendary":
                    this.Damage = val.Next(121, 200);
                    break;
            }
        }
    }
}
