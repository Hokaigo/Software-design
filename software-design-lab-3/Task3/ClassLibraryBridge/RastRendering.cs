using System;

namespace ClassLibraryBridge
{
    public class RastRendering : IRenderingStrategy
    {
        public void Render(Shape shape) => Console.WriteLine($"Drawing {shape.ShapeType} as pixels");
    }
}
