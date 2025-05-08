using ClassLibraryComposite.enums;
using ClassLibraryComposite.Interfaces;

namespace ClassLibraryComposite.Commands
{
    public class EventCommand : ICommand
    {
        private readonly LightElementNode _target;
        private readonly InteractionEvent _event;
        private ILightNodeState _previousState;

        public EventCommand(LightElementNode target, InteractionEvent ev)
        {
            _target = target;
            _event = ev;
        }

        public void Execute()
        {
            _previousState = _target.CurrentState;
            _target.HandleEvent(_event);
        }

        public void Undo() => _target.ForceState(_previousState);
    }
}
