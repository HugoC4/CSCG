using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCG.Models
{
    public class Parameter
    {
        [Key]
        public int ParemetedId { get; set; }
        public string Name { get; set; }
        public string TypeNamespace { get; set; }
        public string TypeName { get; set; }
    }
}
