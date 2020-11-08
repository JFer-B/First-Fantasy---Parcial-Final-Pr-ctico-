using System;
using System.Collections.Generic;
using System.Text;

namespace FIrstFantasyGame.Classes.Equippables
{
    public class Armor
    {
        private string name;
        private string effect;
        private int defense;

        public string Name { get => name; set => name = value; }
        public string Effect { get => effect; set => effect = value; }
        public int Defense { get => defense; set => defense = value; }
    }
}
