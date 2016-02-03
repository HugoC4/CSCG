using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCG.Models;

namespace CSCG
{
    [DbConfigurationType(typeof(CSCGDbConfig))]
    class CSCGContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
    }
}
