using System;
using System.Collections.Generic;
using System.Text;

namespace FIrstFantasyGame.Classes.Subject
{
    public class Rogue : Character
    {
        public Rogue(string name)
        {
            this.Name = name;
            this.Type = "Rogue";
            this.Level = 1;
            this.Experience = 0;
            this.Life = 80;
            this.Mana = 120;
        }
    }
}
