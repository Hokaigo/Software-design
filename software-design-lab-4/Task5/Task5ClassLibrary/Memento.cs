namespace Task5ClassLibrary
{
    public class Memento : IMemento
    {
        public string TextState { get; private set; }

        public Memento(string text) 
        { 
            TextState = text;
        }
    }
}
