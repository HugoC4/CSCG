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
        public DbSet<Class> Class { get; set; }
        public DbSet<Constructor> Constructors { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<Interface> Interfaces { get; set; }
        public DbSet<Method> Methods { get; set; }
        public DbSet<Namespace> Namespaces { get; set; }
        public DbSet<Parameter> Parameters { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Property> Properties { get; set; }
    }
}
