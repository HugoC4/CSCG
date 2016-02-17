using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCG.Code;
using CSCG.Models;

namespace CSCG.Helpers
{
    public class TreeNodeMetaData
    {
        public Accessibility? Accessibility { get; set; }
        public NodeType NodeType { get; set; }
        public string Type { get; set; }
        public virtual Namespace Namespace { get; set; }
        public virtual Project Project { get; set; }
        public virtual Class Class { get; set; }
        public virtual Interface Interface { get; set; }
        public virtual Field Field { get; set; }
        public virtual Property Property { get; set; }
        public virtual Constructor Constructor { get; set; }
        public virtual Method Method { get; set; }
    }
}
