namespace ClassLibraryBridge
{
    public class Triangle : Shape
    {
        public Triangle(IRenderingStrategy renderingStrategy) : base("Triangle", renderingStrategy) { }
        public override void Draw() => renderingStrategy.Render(this);
    }
}
