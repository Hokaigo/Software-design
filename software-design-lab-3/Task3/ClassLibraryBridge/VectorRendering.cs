using System;

namespace ClassLibraryBridge
{
    public class VectorRendering : IRenderingStrategy
    {
        public void Render(Shape shape) => Console.WriteLine($"Drawing {shape.ShapeType} as vector graphics");
    }
}
