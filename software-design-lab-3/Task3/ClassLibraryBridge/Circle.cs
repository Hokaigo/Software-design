namespace ClassLibraryBridge
{
    public class Circle : Shape
    {
        public Circle(IRenderingStrategy renderingStrategy) : base("Circle", renderingStrategy){}
        public override void Draw() => renderingStrategy.Render(this);
    }
}
