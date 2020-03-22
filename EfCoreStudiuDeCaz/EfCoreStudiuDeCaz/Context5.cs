using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreStudiuDeCaz
{
    class Context5 : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public Context5() : base("Server = DESKTOP-F45UG1S\\MSSQLSERVER01;Database=ModelFirst; Trusted_Connection=True; MultipleActiveResultSets=true")
        { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>()
            .Map<FullTimeEmployee>(m => m.Requires("EmployeeType")
            .HasValue(1))
            .Map<HourlyEmployee>(m => m.Requires("EmployeeType")
            .HasValue(2));
        }
    }
}
