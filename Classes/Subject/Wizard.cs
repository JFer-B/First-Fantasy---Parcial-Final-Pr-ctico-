using System;
using System.Collections.Generic;
using System.Text;

namespace FIrstFantasyGame.Classes.Subject
{
    public class Wizard : Character
    {
        public Wizard(string name, Weapon armament)
        {
            this.Name = name;
            this.Type = "Wizard";
            this.Level = 1;
            this.Experience = 0;
            this.Armament = armament;
            this.Life = 100;
            this.Mana = 200;
        }
    }
}
