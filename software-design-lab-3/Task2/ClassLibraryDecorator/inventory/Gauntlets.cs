namespace ClassLibraryDecorator.inventory
{
    public class Gauntlets : HeroDecorator
    {
        public Gauntlets(Hero hero) : base(hero, phyDmgBonus: 3)
        {
            AddToInv("Gauntlets");
        }
    }
}