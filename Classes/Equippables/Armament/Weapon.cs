using System;
using System.Collections.Generic;
using System.Text;

namespace FIrstFantasyGame.Classes
{
    public abstract class Weapon
    {
        private string type;
        private string name;
        private int damage;
        private string range;
        private string rarity;

        public string Type { get => type; set => type = value; }
        public int Damage { get => damage; set => damage = value; }
        public string Range { get => range; set => range = value; }
        public string Rarity { get => rarity; set => rarity = value; }
        public string Name { get => name; set => name = value; }
    }
}
