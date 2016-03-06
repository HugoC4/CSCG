using System.ComponentModel.DataAnnotations;

namespace CSCG.Models
{
    public class Parameter : ModelBase
    {
        [Key]
        public int ParemetedId { get; set; }
        public string Name { get; set; }
        public virtual Namespace Namespace { get; set; }
        public string NamespaceGen { get; set; }
        public virtual Class Class { get; set; }
        public string ClassCustom { get; set; }
        public virtual Interface Interface { get; set; }
    }
}
