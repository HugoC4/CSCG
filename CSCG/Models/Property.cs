using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCG.Code;

namespace CSCG.Models
{
    public class Property : Accessible
    {
        [Key]
        public int PropertyId { get; set; }
        public string TypeName { get; set; }
        public Type Type { get; set; }
        public bool HasCustomType { get; set; }
        public bool IsAutoProperty { get; set; } = false;
        public bool ReadOnly { get; set; } = false;

        public virtual Class Class { get; set; }

        public static Accessibility DefaultAccessibility = Accessibility.Private;
        public static List<Accessibility> AllowedAccessibilities = new List<Accessibility>()
        {
            Accessibility.Public,
            Accessibility.Private,
            Accessibility.Protected,
            Accessibility.Internal,
            Accessibility.ProtectedInternal
        };
    }
}
