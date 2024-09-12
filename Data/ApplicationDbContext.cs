using Carrental.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Carrental.WebAPI.Data
{
    public partial class ApplicationDbContext: DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<VehicleModel> VehicleModels { get; set; }
        public DbSet<VehicleCategory> VehicleCategories { get; set; }
        public DbSet<VehicleBrand> VehicleBrands { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<VehicleBrand>().HasKey(vb => vb.BrandId);
            modelBuilder.Entity<VehicleCategory>().HasKey(vc => vc.CategoryId);
            modelBuilder.Entity<VehicleModel>().HasKey(vm => vm.ModelId);
            modelBuilder.Entity<Vehicle>().HasKey(v => v.VehicleId);
            modelBuilder.Entity<Location>().HasKey(l => l.Id);
            modelBuilder.Entity<Booking>().HasKey(b => b.Id);
            modelBuilder.Entity<Vehicle>()
                .HasOne(v => v.Model)
                .WithMany()
                .HasForeignKey(v => v.ModelId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Vehicle>()
                .HasOne(v => v.Brand)
                .WithMany()
                .HasForeignKey(v => v.BrandId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Vehicle>()
                .HasOne(v => v.Category)
                .WithMany()
                .HasForeignKey(v => v.CategoryId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Vehicle)
                .WithMany()
                .HasForeignKey(b => b.VehicleId)
                .OnDelete(DeleteBehavior.SetNull);

            base.OnModelCreating(modelBuilder);
        }


    }
}
