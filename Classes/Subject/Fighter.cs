using System;
using System.Collections.Generic;
using System.Text;

namespace FIrstFantasyGame.Classes.Subject
{
    public class Fighter : Character
    {
        public Fighter(string name, Weapon armament)
        {
            this.Name = name;
            this.Type = "Fighter";
            this.Level = 1;
            this.Experience = 0;
            this.Armament = armament;
            this.Life = 200;
            this.Mana = 100;
        }
    }
}
