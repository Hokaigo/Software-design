namespace Task3ClassLibrary
{
    public interface IEventListener
    {
        void HandleEvent(string eventType, LightElementNode target);
    }
}
