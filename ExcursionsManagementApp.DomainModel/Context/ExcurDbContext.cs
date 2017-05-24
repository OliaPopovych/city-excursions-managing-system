namespace ExcursionsManagementApp.DomainModel
{
    using Context;
    using Entities;
    using System;
    using System.Data.Entity;

    public partial class ExcurDbContext : DbContext
    {
        public ExcurDbContext()
            : base("ExcursionsDB")
        {
            Type providerService = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
            //    Configuration.LazyLoadingEnabled = false;
            //    Configuration.ProxyCreationEnabled = false;
           // var context = new ExcurDbContext("ExcursionsDB");
           // Database.SetInitializer<ExcurDbContext>(new DBInitializer());
           // Database.SetInitializer<ExcurDbContext>(new System.Data.Entity.CreateDatabaseIfNotExists<ExcurDbContext>());
            // context.Database.Initialize(true);
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Guide> Guides { get; set; }
        public virtual DbSet<Place> Places { get; set; }
        public virtual DbSet<ScheduleEntry> Schedule { get; set; }
        public virtual DbSet<Tour> Tours { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tour>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);
        }
    }
}
