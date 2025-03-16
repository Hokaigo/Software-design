namespace ClassLibraryDecorator
{
    public class Warrior : Hero
    {
        public Warrior(string name) : base(name, 100, 30, 3){}
        public override string ToString() => $"Warrior's name: {Name}; health: {Health}; physical damage {PhysicalDamage}; magic damage {MagicDamage}";
    }
}
