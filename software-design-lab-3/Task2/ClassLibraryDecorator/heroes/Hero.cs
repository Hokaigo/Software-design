using System.Collections.Generic;

namespace ClassLibraryDecorator
{
    public abstract class Hero
    {
        public string Name { get; protected set; }
        public virtual int Health { get; protected set; }
        public virtual int PhysicalDamage { get; protected set; }
        public virtual int MagicDamage { get; protected set; }
        public virtual List<string> Inventory { get; protected set; } = new List<string>();

        public Hero(string name, int health, int phyDmg, int magDmg)
        {
            Name = name;
            Health = health;
            PhysicalDamage = phyDmg;
            MagicDamage = magDmg;
        }

        public override string ToString()
        {
            return $"{GetType().Name} {Name}: health {Health}, physical damage {PhysicalDamage}, magic damage {MagicDamage}";
        }
    }
}
