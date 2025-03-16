namespace ClassLibraryDecorator.inventory
{
    public class Staff : HeroDecorator
    {
        public Staff(Hero hero) : base(hero, magDmgBonus: 10)
        {
            AddToInv("Staff");
        }
    }
}
