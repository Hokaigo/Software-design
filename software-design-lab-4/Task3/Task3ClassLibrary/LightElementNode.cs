using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3ClassLibrary
{
    public class LightElementNode : LightNode, ILightContainer
    {
        public string TagName { get; }
        public DisplayType Display { get; }
        public bool SelfClosing { get; }
        public List<string> CssClasses { get; private set; }
        private List<LightNode> _children;
        private Dictionary<string, List<IEventListener>> _eventListeners;

        public LightElementNode(string tagName, DisplayType display, bool selfClosing)
        {
            TagName = tagName;
            Display = display;
            SelfClosing = selfClosing;
            CssClasses = new List<string>();
            _children = new List<LightNode>();
            _eventListeners = new Dictionary<string, List<IEventListener>>();

        }

        public void AddClass(string className) => CssClasses.Add(className);

        public void AddChild(LightNode child)
        {
            if (SelfClosing)
                throw new InvalidOperationException($"Self-closing tag cannot have child elements.");

            _children.Add(child);
        }

        public override string GetInnerHtml()
        {
            return string.Join("", _children.ConvertAll(child => child.GetOuterHtml()));
        }

        public override string GetOuterHtml(int indentLevel = 0)
        {
            string indent = new string(' ', indentLevel * 2);
            string style = $"style=\"display: {(Display == DisplayType.Block ? "block" : "inline")};\"";
            string classes = CssClasses.Count > 0 ? $" class=\"{string.Join(" ", CssClasses)}\"" : "";

            if (SelfClosing)
                return $"{indent}<{TagName}{classes} {style} />\n";

            string childrenHtml = string.Join("", _children.Select(child =>
                child.GetOuterHtml(indentLevel + 1)
            ));

            return $"{indent}<{TagName}{classes} {style}>\n{childrenHtml}{indent}</{TagName}>\n";
        }

        public LightElementNode Clone()
        {
            return new LightElementNode(this.TagName, this.Display, this.SelfClosing)
            {
                CssClasses = new List<string>(this.CssClasses)
            };
        }

        public void AddEventListener(string eventType, IEventListener listener)
        {
            if (!_eventListeners.ContainsKey(eventType))
                _eventListeners[eventType] = new List<IEventListener>();

            _eventListeners[eventType].Add(listener);
        }

        public void NotifyEvent(string eventType)
        {
            if (_eventListeners.ContainsKey(eventType))
                _eventListeners[eventType].ForEach((listener) => listener.HandleEvent(eventType, this));
        }
    }
}
