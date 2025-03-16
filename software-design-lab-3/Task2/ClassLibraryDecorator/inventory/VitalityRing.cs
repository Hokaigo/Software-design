namespace ClassLibraryDecorator.inventory
{
    public class VitalityRing : HeroDecorator
    {
        public VitalityRing(Hero hero) : base(hero, healthBonus: 20)
        {
            AddToInv("Vitality Ring");
        }
    }
}
