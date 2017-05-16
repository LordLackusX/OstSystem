namespace OstSysWeb
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OstSysContext : DbContext
    {
        public OstSysContext()
            : base("name=OstSysContext")
        {
            base.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Apartment> Apartments { get; set; }
        public virtual DbSet<Resident> Residents { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Apartment>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Apartment>()
                .Property(e => e.Side)
                .IsUnicode(false);

            modelBuilder.Entity<Resident>()
                .Property(e => e.Resident_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Resident>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Resident>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Resident>()
                .Property(e => e.Email)
                .IsUnicode(false);
        }
    }
}
