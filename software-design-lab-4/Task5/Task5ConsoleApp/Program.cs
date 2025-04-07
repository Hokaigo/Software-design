using Task5ClassLibrary;

namespace Task5ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextDocument document = new TextDocument("Hello world!");
            TextEditor te = new TextEditor(document);

            te.Display();
            te.AppendText(" I'm learning design patterns.");
            te.Display();
            te.Undo();
            te.Display();
        }
    }
}
