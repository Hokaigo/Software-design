using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderClassLibrary
{
    public class Character
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public string Build { get; set; }
        public string HairColor { get; set; }
        public string EyesColor { get; set; }
        public string Clothing { get; set; }
        public string Inventory { get; set; }
        public List<string> GoodActions { get; set; } = new List<string>();
        public List<string> BadActions { get; set; } = new List<string>();

        public override string ToString() => $"Name: {Name}, Height: {Height} cm, Build: {Build}, Hair color: {HairColor}, Eyes color: {EyesColor}" +
            $", Clothing: {Clothing}, Inventory: {Inventory}, Good actions: ({string.Join(", ", GoodActions)})," +
            $" Bad actions: ({string.Join(", ", BadActions)})";
    }
}
