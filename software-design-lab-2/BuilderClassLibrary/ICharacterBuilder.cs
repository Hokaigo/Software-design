using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderClassLibrary
{
    public interface ICharacterBuilder 
    {
        ICharacterBuilder SetName(string name);
        ICharacterBuilder SetHeight(int height);
        ICharacterBuilder SetBuild(string build);
        ICharacterBuilder SetHairColor(string hairColor);
        ICharacterBuilder SetClothing(string clothing);
        ICharacterBuilder SetEyesColor(string eyesColor);
        ICharacterBuilder SetInventory(string inventory);
        ICharacterBuilder AddGoodAction(string action);
        ICharacterBuilder AddBadAction(string action);
        Character Build();
    }
}
