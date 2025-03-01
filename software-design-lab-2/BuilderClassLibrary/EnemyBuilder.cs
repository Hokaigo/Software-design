using System;
using System.Collections.Generic;

namespace BuilderClassLibrary
{
    public class EnemyBuilder : ICharacterBuilder
    {
        private Character _enemy = new Character();

        public Character Build() => _enemy;

        public ICharacterBuilder SetBuild(string build) { _enemy.Build = build; return this; }
        public ICharacterBuilder SetClothing(string clothing) { _enemy.Clothing = clothing; return this; }
        public ICharacterBuilder SetEyesColor(string eyeColor) { _enemy.EyesColor = eyeColor; return this; }
        public ICharacterBuilder SetHairColor(string hairColor) { _enemy.HairColor = hairColor; return this; }
        public ICharacterBuilder SetHeight(int height) { _enemy.Height = height; return this; }
        public ICharacterBuilder SetInventory(string inventory) { _enemy.Inventory = inventory; return this; }
        public ICharacterBuilder SetName(string name) { _enemy.Name = name; return this; }
        public ICharacterBuilder AddBadAction(string action) { _enemy.BadActions.Add(action); return this; }
        public ICharacterBuilder AddGoodAction(string action) { _enemy.GoodActions.Add(action); return this; }
    }

}
