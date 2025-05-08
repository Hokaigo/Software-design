using ClassLibraryComposite.Interfaces;
using System.Collections.Generic;

namespace ClassLibraryComposite.Commands
{
    public class CommandManager
    {
        private readonly Stack<ICommand> _done = new Stack<ICommand>();
        private readonly Stack<ICommand> _undone = new Stack<ICommand>();

        public void Execute(ICommand cmd)
        {
            cmd.Execute();
            _done.Push(cmd);
            _undone.Clear();
        }

        public void Undo()
        {
            if (_done.Count == 0) return;
            var cmd = _done.Pop();
            cmd.Undo();
            _undone.Push(cmd);
        }

        public void Redo()
        {
            if (_undone.Count == 0) return;
            var cmd = _undone.Pop();
            cmd.Execute();
            _done.Push(cmd);
        }
    }
}
