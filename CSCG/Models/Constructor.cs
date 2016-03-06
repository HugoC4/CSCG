using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CSCG.Models
{
    public class Constructor : ModelBase
    {
        [Key]
        public int ConstructorId { get; set; }
        public virtual Dictionary<int, Parameter> Parameters { get; set; }

        public virtual Class Class { get; set; }
        public Accessibility Accessibility { get; set; }

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
