namespace ExcursionsManagementApp.DomainModel
{
    using System.Data.Entity;

    public partial class ExcurDbContext : DbContext
    {
        public ExcurDbContext()
            : base("DataBase")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Guide> Guides { get; set; }
        public virtual DbSet<Place> Places { get; set; }
        public virtual DbSet<ScheduleEntry> Schedule { get; set; }
        public virtual DbSet<Tour> Tours { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tour>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);
        }
    }
}
