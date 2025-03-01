using BuilderClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            Character hero = director.CreateHero(new HeroBuilder());
            Character enemy = director.CreateEnemy(new EnemyBuilder());

            Console.WriteLine("My Hero:");
            Console.WriteLine(hero);

            Console.WriteLine("\nMy Enemy:");
            Console.WriteLine(enemy);
        }
    }
}
