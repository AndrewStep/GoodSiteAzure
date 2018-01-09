namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CarContext : DbContext
    {
        public CarContext()
            : base("name=CarContext")
        {
        }

        public virtual DbSet<CARSINFO> CARSINFO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CARSINFO>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<CARSINFO>()
                .Property(e => e.CarName)
                .IsUnicode(false);

            modelBuilder.Entity<CARSINFO>()
                .Property(e => e.Color)
                .IsUnicode(false);

            modelBuilder.Entity<CARSINFO>()
                .Property(e => e.CarImage)
                .IsUnicode(false);
        }
    }
}
