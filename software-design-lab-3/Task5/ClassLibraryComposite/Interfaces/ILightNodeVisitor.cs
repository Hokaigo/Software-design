using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryComposite.Interfaces
{
    public interface ILightNodeVisitor
    {
        void Visit(LightTextNode textNode, int depth);
        void Visit(LightElementNode elementNode, int depth);
    }
}
