namespace ClassLibraryDecorator.inventory
{
    public class Sword : HeroDecorator
    {
        public Sword(Hero hero) : base(hero)
        {
            PhysicalDamage += 5;
            AddToInv("Sword");
        }
    }
}
