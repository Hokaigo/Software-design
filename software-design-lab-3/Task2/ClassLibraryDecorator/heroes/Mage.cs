namespace ClassLibraryDecorator
{
    public class Mage : Hero
    {
        public Mage(string name) : base(name, 70, 0, 50){}
        public override string ToString() => $"Mage's name: {Name}; health: {Health}; physical damage {PhysicalDamage}; magic damage {MagicDamage}";
    }
}
