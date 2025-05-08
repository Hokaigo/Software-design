using ClassLibraryComposite.interfaces;
using System;

namespace ClassLibraryComposite.States
{
    public class NormalState : ILightNodeState
    {
        public void OnEnter(LightElementNode node)
        {
            node.RemoveClass("hover");
            node.RemoveClass("active");
            node.AddClass("normal");
            Console.WriteLine("Entered Normal state.");
        }

        public void OnExit(LightElementNode node)
        {
            node.RemoveClass("normal");
            Console.WriteLine("Exited Normal state.");
        }
    }

}
