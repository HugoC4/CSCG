using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCG.Code;

namespace CSCG.Models
{
    public class Method : Accessible
    {
        [Key]
        public int MethodId { get; set; }
        public string Name { get; set; }
        public string ReturnTypeName { get; set; }
        public Type ReturnType { get; set; }
        public bool HasCustomReturnType { get; set; }

        public virtual Dictionary<int, Parameter> Parameters { get; set; }

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
