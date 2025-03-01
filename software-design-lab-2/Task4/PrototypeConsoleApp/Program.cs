using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            Virus firstVirus = new Virus("First", "Type-A", 1.3, 2);

            Virus child1 = new Virus("FirstChild", "Type-B", 0.9, 1);
            Virus child2 = new Virus("SecondChild", "Type-A", 1.1, 3);

            firstVirus.AddChild(child1);
            firstVirus.AddChild(child2);

            child1.AddChild(new Virus("FirstGrandchild", "Type-A", 0.5, 1));
            child2.AddChild(new Virus("SecondGrandchild", "Type-C", 0.7, 2));

            Virus clonedFamily = (Virus)firstVirus.Clone();

            Console.WriteLine("Original Structure:");
            firstVirus.ShowFamilyTree();

            Console.WriteLine("\nCloned Structure:");
            clonedFamily.ShowFamilyTree();
        }
    }
}
