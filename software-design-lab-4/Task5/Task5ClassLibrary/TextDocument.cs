using System;

namespace Task5ClassLibrary
{
    public class TextDocument : ITextDocumentOriginator
    {
        public string Text { get; set; }

        public TextDocument(string text) 
        { 
            Text = text;
        }

        public void Restore(IMemento snapshot)
        {
            if (snapshot is Memento m)
            {
                Text = m.TextState;
            }
            else
            {
                throw new ArgumentException("The snapshot is not of type Memento");
            }
        }

        public IMemento Save() => new Memento(Text);
    }
}
