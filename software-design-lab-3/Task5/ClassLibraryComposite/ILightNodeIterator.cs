using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryComposite
{
    public interface ILightNodeIterator
    {
        IEnumerable<LightNode> DepthFirst();
        IEnumerable<LightNode> BreadthFirst();
    }
}
