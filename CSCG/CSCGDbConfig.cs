using System.Data.Entity;

namespace CSCG
{
    class CSCGDbConfig : DbConfiguration
    {
        public CSCGDbConfig()
        {
            SetDefaultConnectionFactory(new System.Data.Entity.Infrastructure.SqlConnectionFactory());
        }
    }
}
