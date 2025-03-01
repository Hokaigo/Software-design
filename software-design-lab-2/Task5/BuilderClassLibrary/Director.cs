using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderClassLibrary
{
    public class Director
    {
        public Character CreateHero(ICharacterBuilder heroBuilder) => heroBuilder
            .SetName("Voltage").SetHeight(180).SetBuild("Lean physique")
            .SetHairColor("Silver").SetClothing("Assassin's robe").SetEyesColor("Dark brown")
            .SetInventory("Dagger and healing potions")
            .AddGoodAction("Saved a village").AddGoodAction("Prevented a disaster").AddBadAction("Accidentally killed an innocent dweller")
            .Build();

        public Character CreateEnemy(ICharacterBuilder enemyBuilder) => enemyBuilder
            .SetName("Cursed king").SetHeight(200).SetBuild("Muscular physique")
            .SetHairColor("Black").SetClothing("Dark knight's armor")
            .SetEyesColor("Void black").SetInventory("Cursed heavy sword")
            .AddBadAction("Destroyed two villages").AddBadAction("Robbed king's treasure house")
            .Build();
    }


}
