using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCG.Code;

namespace CSCG.Models
{
    public class Class : Accessible
    {
        [Key]
        public int ClassId { get; set; }
        public string Name { get; set; }
        public bool IsAbstract { get; set; }
        public virtual Class Extends { get; set; }
        public virtual List<Interface> Implements { get; set; }
        public virtual List<Namespace> Usings { get; set; }
        public virtual List<string> InternalUsings { get; set; }
        public virtual Namespace Namespace { get; set; }
        public virtual List<Property> Properties { get; set; }
        public virtual List<Field> Fields { get; set; }
        public virtual List<Method> Methods { get; set; }
        public virtual List<Constructor> Constructors { get; set; }


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
