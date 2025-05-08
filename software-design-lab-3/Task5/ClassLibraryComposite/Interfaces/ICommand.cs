namespace ClassLibraryComposite.Interfaces
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
