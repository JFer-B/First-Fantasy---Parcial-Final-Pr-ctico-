using System;
using System.Collections.Generic;
using System.Text;

namespace FIrstFantasyGame.Classes.Subject
{
    public class Cleric : Character
    {
        public Cleric(string name)
        {
            this.Name = name;
            this.Type = "Cleric";
            this.Level = 1;
            this.Experience = 0;
            this.Life = 150;
            this.Mana = 150;
        }
    }
}
