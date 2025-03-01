using System.Collections.Generic;

namespace BuilderClassLibrary
{
    public class HeroBuilder : ICharacterBuilder
    {
        private Character _hero = new Character();

        public Character Build() => _hero;

        public ICharacterBuilder SetBuild(string build) { _hero.Build = build; return this; }
        public ICharacterBuilder SetClothing(string clothing) { _hero.Clothing = clothing; return this; }
        public ICharacterBuilder SetEyesColor(string eyeColor) { _hero.EyesColor = eyeColor; return this; }
        public ICharacterBuilder SetHairColor(string hairColor) { _hero.HairColor = hairColor; return this; }
        public ICharacterBuilder SetHeight(int height) { _hero.Height = height; return this; }
        public ICharacterBuilder SetInventory(string inventory) { _hero.Inventory = inventory; return this; }
        public ICharacterBuilder SetName(string name) { _hero.Name = name; return this; }
        public ICharacterBuilder AddGoodAction(string action) { _hero.GoodActions.Add(action); return this; }
        public ICharacterBuilder AddBadAction(string action) { _hero.BadActions.Add(action); return this; }
    }


}
