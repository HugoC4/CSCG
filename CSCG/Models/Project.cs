using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCG.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public string Namespace { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
