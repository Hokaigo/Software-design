namespace Task5ClassLibrary
{
    public interface ITextDocumentOriginator
    {
        IMemento Save();
        void Restore(IMemento snapshot);
    }
}
