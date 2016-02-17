using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCG
{
    public enum ViewState
    {
        Project,
        Namespace,

    }

    public enum NodeType
    {
        Root,
        Namespace,
        Class,
        Interface,
        Abstract,
        Constructor,
        Field,
        Property,
        Method
    }
}
