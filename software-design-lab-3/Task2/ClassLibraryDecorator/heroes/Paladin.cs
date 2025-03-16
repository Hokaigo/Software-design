namespace ClassLibraryDecorator
{
    public class Paladin : Hero
    {
        public Paladin(string name) : base(name, 200, 10, 10){}
        public override string ToString() => $"Paladin's name: {Name}; health: {Health}; physical damage {PhysicalDamage}; magic damage {MagicDamage}";
    }
}
