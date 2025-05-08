namespace ClassLibraryComposite
{
    public interface ILightContainer
    {
        void AddChild(LightNode child);
        void RemoveChild(LightNode child);
    }
}
