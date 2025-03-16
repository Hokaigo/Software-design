using System.Collections.Generic;

namespace ClassLibraryDecorator
{
    public class HeroDecorator : Hero
    {
        protected Hero hero;

        public HeroDecorator(Hero hero, int healthBonus = 0, int phyDmgBonus = 0, int magDmgBonus = 0)
            : base(hero.Name, hero.Health + healthBonus, hero.PhysicalDamage + phyDmgBonus, hero.MagicDamage + magDmgBonus)
        {
            this.hero = hero;
            Inventory = new List<string>(hero.Inventory);
        }

        protected void AddToInv(string item)
        {
            Inventory.Add(item);
        }

        public override string ToString()
        {
            return $"{base.ToString()}; Inventory: {(Inventory.Count > 0 ? string.Join(", ", Inventory) : "empty")}";
        }
    }
}
