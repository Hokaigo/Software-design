using ClassLibraryComposite.Interfaces;
using System;

namespace ClassLibraryComposite.States
{
    public class ActiveState : ILightNodeState
    {
        public void OnEnter(LightElementNode node)
        {
            node.RemoveClass("hover");
            node.AddClass("active");
            Console.WriteLine("Entered Active state.");
        }

        public void OnExit(LightElementNode node)
        {
            node.RemoveClass("active");
            Console.WriteLine("Exited Active state.");
        }
    }

}
