using ClassLibraryBridge;
using System.Collections.Generic;

namespace ConsoleAppBridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>
            {
                new Circle(new VectorRendering()),
                new Square(new VectorRendering()),
                new Triangle(new VectorRendering())
            };

            foreach (var shape in shapes)
            {
                shape.Draw();
            }

            foreach (var shape in shapes)
            {
                shape.SetRenderingStrategy(new RastRendering());
                shape.Draw();
            }
        }
    }
}
