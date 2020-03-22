namespace EfCoreStudiuDeCaz
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Model1 : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EfCoreStudiuDeCaz.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public Model1()
            : base("Server = DESKTOP-F45UG1S\\MSSQLSERVER01;Database=ModelFirst; Trusted_Connection=True")
        {
        }

        public virtual DbSet<SelfReference> SelfReferences { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SelfReference>()
            .HasMany(m => m.References)
            .WithOptional(m => m.ParentSelfReference);
        }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}