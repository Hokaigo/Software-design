namespace ClassLibraryBridge
{
    public class Square : Shape
    {
        public Square(IRenderingStrategy renderingStrategy) : base("Square", renderingStrategy) { }
        public override void Draw() => renderingStrategy.Render(this);
    }
}
