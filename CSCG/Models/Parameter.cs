using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string TypeName { get; set; }
        public Type Type { get; set; }
    }
}
