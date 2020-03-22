using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreStudiuDeCaz
{
    class EF6RecipesContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public EF6RecipesContext() : base("Server = DESKTOP-F45UG1S\\MSSQLSERVER01;Database=ModelFirst; Trusted_Connection=True")
        { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
            .Map(m =>
            {
                m.Properties(p => new { p.SKU, p.Description, p.Price });
                m.ToTable("Product", "BazaDeDate");
            })
            .Map(m =>
            {
                m.Properties(p => new { p.SKU, p.ImageURL });
                m.ToTable("ProductWebInfo", "BazaDeDate");
            });
        }
    }
}