using System.Collections.Generic;

namespace ClassLibraryComposite
{
    public interface ILightNodeIterator
    {
        IEnumerable<LightNode> DepthFirst();
        IEnumerable<LightNode> BreadthFirst();
    }
}
