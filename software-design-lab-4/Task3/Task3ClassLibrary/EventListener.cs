using System;

namespace Task3ClassLibrary
{
    public class EventListener : IEventListener
    {
        public void HandleEvent(string eventType, LightElementNode target) =>
            Console.WriteLine($"An event \"{eventType}\" handled on <{target.TagName}> element.");
    }
}
