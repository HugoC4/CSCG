using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCG.Models
{
    public class Project : ModelBase
    {
        [Key]
        [ForeignKey("Namespace")]
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public Accessibility DefaultAccessibility { get; set; }
        public virtual Namespace Namespace { get; set; }
    }
}
