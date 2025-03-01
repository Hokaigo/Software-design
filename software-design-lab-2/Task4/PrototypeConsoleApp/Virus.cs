using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeConsoleApp
{
    public class Virus : ICloneable
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public List<Virus> ChildViruses { get; set; }


        public Virus(string name, string type, double weight, int age) { 
            Name = name;
            Type = type;
            Weight = weight;
            Age = age;
            ChildViruses = new List<Virus>();
        }

        public void AddChild(Virus child)
        {
            ChildViruses.Add(child);
        }

        public object Clone()
        {
            Virus clone = new Virus(Name, Type, Weight, Age);
            foreach (var child in ChildViruses)
            {
                clone.ChildViruses.Add((Virus)child.Clone());
            }
            return clone;
        }

        public void ShowFamilyTree()
        {
            Console.WriteLine($"Name: {Name}, Type: {Type}, Weight: {Weight}, Age: {Age}");
            foreach (var child in ChildViruses)
            {
                child.ShowFamilyTree();
            }
        }

    }
}
