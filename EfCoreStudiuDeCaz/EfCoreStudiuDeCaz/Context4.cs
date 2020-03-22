using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreStudiuDeCaz
{
    public class Context4 : DbContext
    {
        public DbSet<Business> Businesses { get; set; }
        public Context4() : base("Server = DESKTOP-F45UG1S\\MSSQLSERVER01;Database=ModelFirst; Trusted_Connection=True; MultipleActiveResultSets=true")
        { }
    }
}
