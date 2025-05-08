using ClassLibraryComposite.interfaces;
using System;

namespace ClassLibraryComposite.States
{
    public class HoverState : ILightNodeState
    {
        public void OnEnter(LightElementNode node)
        {
            node.RemoveClass("normal");
            node.AddClass("hover");
            Console.WriteLine("Entered Hover state.");
        }

        public void OnExit(LightElementNode node)
        {
            node.RemoveClass("hover");
            Console.WriteLine("Exited Hover state.");
        }
    }

}
