using System;
using System.Collections.Generic;
using System.Text;

namespace FIrstFantasyGame.Classes.Equippables.Armament
{
    public class Dagger : Weapon
    {
        public Dagger(string name, string rarity)
        {
            this.Name = name;
            this.Type = "Dagger";
            this.Range = "Short";
            Random val = new Random();
            switch (rarity)
            {
                case "Common":
                    this.Damage = val.Next(1, 8);
                    break;
                case "Uncommon":
                    this.Damage = val.Next(9, 20);
                    break;
                case "Rare":
                    this.Damage = val.Next(21, 40);
                    break;
                case "Epic":
                    this.Damage = val.Next(41, 75);
                    break;
                case "Legendary":
                    this.Damage = val.Next(76, 100);
                    break;
            }
        }
    }
}
