using FIrstFantasyGame.Classes.Equippables;
using System;
using System.Collections.Generic;
using System.Text;

namespace FIrstFantasyGame.Classes.Subject
{
    public class Fighter : Character
    {
        public Fighter(string name)
        {
            this.Name = name;
            this.Type = "Fighter";
            this.Level = 1;
            this.Experience = 0;
            this.Life = 200;
            this.Mana = 100;
            this.WeaponInventory = new List<Weapon>();
            this.ArmorInventory = new List<Armor>();
            this.PotionInventory = new List<Potion>();
        }
    }
}
