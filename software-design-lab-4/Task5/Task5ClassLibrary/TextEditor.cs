using System;
using System.Collections.Generic;

namespace Task5ClassLibrary
{
    public class TextEditor
    {
        private TextDocument _document;
        private Stack<IMemento> _history = new Stack<IMemento>();

        public TextEditor(TextDocument document)
        {
            _document = document;
        }

        public void SaveState() => _history.Push(_document.Save());

        public void AppendText(string text)
        {
            SaveState();
            _document.Text += text;
        }

        public void Undo()
        {
            if (_history.Count > 0)
            {
                var memento = _history.Pop();
                _document.Restore(memento);
            }
            else
            {
                Console.WriteLine("Here isn't any availbale.");
            }
        }

        public void Display() => Console.WriteLine("->" + _document.Text);
    }
}
