namespace ClassLibraryComposite.Interfaces
{
    public interface ILightContainer
    {
        void AddChild(LightNode child);
        void RemoveChild(LightNode child);
    }
}
