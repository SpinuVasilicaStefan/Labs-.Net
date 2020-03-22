using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreStudiuDeCaz
{
    public class Context3 : DbContext
    {
        public DbSet<Photograph> Photographs { get; set; }
        public DbSet<PhotographFullImage> PhotographFullImage { get; set; }
        public Context3() : base("Server = DESKTOP-F45UG1S\\MSSQLSERVER01;Database=ModelFirst; Trusted_Connection=True; MultipleActiveResultSets=true")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Photograph>()
            .HasRequired(p => p.PhotographFullImage)
            .WithRequiredPrincipal(p => p.Photograph);
            modelBuilder.Entity<Photograph>()
            .ToTable("Photograph", "BazaDeDate");
            modelBuilder.Entity<PhotographFullImage>()
            .ToTable("Photograph", "BazaDeDate");
        }


    }
}
