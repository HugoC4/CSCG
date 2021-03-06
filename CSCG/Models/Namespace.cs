﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CSCG.Models
{
    public class Namespace : ModelBase
    {
        [Key]
        public int NamespaceId { get; set; }
        public string Name { get; set; }
        public virtual Namespace Parent { get; set; }
        public virtual List<Namespace> Namespaces { get; set; } 
        public virtual List<Class> Classes { get; set; }
        public virtual List<Interface> Interfaces { get; set; }
        public virtual Project Project { get; set; }
    }
}
