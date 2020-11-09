using FIrstFantasyGame.Classes.Equippables;
using System;
using System.Collections.Generic;
using System.Text;

namespace FIrstFantasyGame.Classes.Subject
{
    public class Wizard : Character
    {
        public Wizard(string name)
        {
            this.Name = name;
            this.Type = "Wizard";
            this.Level = 1;
            this.Experience = 0;
            this.Life = 100;
            this.Mana = 200;
            this.WeaponInventory = new List<Weapon>();
            this.ArmorInventory = new List<Armor>();
            this.PotionInventory = new List<Potion>();
        }
    }
}
