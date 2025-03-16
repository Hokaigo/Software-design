using ClassLibraryDecorator;
using ClassLibraryDecorator.inventory;
using System;

namespace ConsoleAppDecorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero warrior = new Warrior("Blightbringer");
            Hero mage = new Mage("Scarlet Reaper");
            Hero paladin = new Paladin("Saint Arothel");

            Console.WriteLine($"{warrior}\n{mage}\n{paladin}\n");

            warrior = new Sword(warrior);
            warrior = new Gauntlets(warrior);

            paladin = new Sword(paladin);
            paladin = new VitalityRing(paladin);

            mage = new Staff(mage);

            Console.WriteLine($"{warrior}\n{mage}\n{paladin}\n");
        }
    }
}
