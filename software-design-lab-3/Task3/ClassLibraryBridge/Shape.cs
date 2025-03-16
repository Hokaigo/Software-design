namespace ClassLibraryBridge
{
    public abstract class Shape
    {
        protected IRenderingStrategy renderingStrategy;
        public string ShapeType { get; }

        protected Shape(string shapeType, IRenderingStrategy renderingStrategy)
        {
            ShapeType = shapeType;
            this.renderingStrategy = renderingStrategy;
        }

        public void SetRenderingStrategy(IRenderingStrategy renderingStrategy)
        {
            this.renderingStrategy = renderingStrategy;
        }

        public abstract void Draw();
    }
}
