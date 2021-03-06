﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CSCG.Models
{
    public class Property : ModelBase
    {
        [Key]
        public int PropertyId { get; set; }
        public string TypeNamespace { get; set; }
        public string TypeName { get; set; }
        public bool IsAutoProperty { get; set; } = false;
        public bool ReadOnly { get; set; } = false;

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
