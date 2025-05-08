using System.Collections.Generic;

namespace ClassLibraryComposite.Interfaces
{
    public interface ILightNodeIterator
    {
        IEnumerable<LightNode> DepthFirst();
        IEnumerable<LightNode> BreadthFirst();
    }
}
