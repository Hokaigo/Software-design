using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibraryComposite
{
    public class LightElementNode : LightNode, ILightContainer, ILightNodeIterator
    {
        public string TagName { get; }
        public DisplayType Display { get; }
        public bool SelfClosing { get; }
        public List<string> CssClasses { get; private set; }
        private List<LightNode> _children;  

        public LightElementNode(string tagName, DisplayType display, bool selfClosing)
        {
            TagName = tagName;
            Display = display;
            SelfClosing = selfClosing;
            CssClasses = new List<string>();
            _children = new List<LightNode>();
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

        public IEnumerable<LightNode> DepthFirst()
        {
            yield return this;
            foreach(var child  in _children)
            {
                if(child is ILightNodeIterator enumerable)
                {
                    foreach(var desc in enumerable.DepthFirst())
                        yield return desc;
                }
                else yield return child;
            }
        }

        public IEnumerable<LightNode> BreadthFirst()
        {
            var list = new List<LightNode> { this };
            for(int i = 0; i < list.Count; i++)
            {
                var current = list[i];
                yield return current;
                if(current is LightElementNode elem)
                {
                    foreach(var curr in elem._children)
                    {
                        list.Add(curr);
                    }
                }
            }
        }
    }
}
