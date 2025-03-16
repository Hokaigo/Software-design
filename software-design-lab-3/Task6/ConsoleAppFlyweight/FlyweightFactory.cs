using System.Collections.Generic;
using ClassLibraryComposite;

namespace ConsoleAppFlyweight
{
    public class FlyweightFactory
    {
        private readonly Dictionary<string, LightElementNode> _elems = new Dictionary<string, LightElementNode>();

        public LightElementNode GetElement(string tagName)
        {
            if (!_elems.ContainsKey(tagName))
                _elems[tagName] = new LightElementNode(tagName, DisplayType.Block, false);

            return _elems[tagName].Clone();
        }
    }
}
