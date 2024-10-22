using Carrental.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Carrental.WebAPI.Data
{
    public partial class ApplicationDbContext : DbContext
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
        public DbSet<VehicleImage> VehicleImages { get; set; }

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
                .WithMany(vm => vm.Vehicles)
                .HasForeignKey(v => v.ModelId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Vehicle>()
                .HasOne(v => v.Brand)
                .WithMany(vb => vb.Vehicles)
                .HasForeignKey(v => v.BrandId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Vehicle>()
                .HasOne(v => v.Category)
                .WithMany(vc => vc.Vehicles)
                .HasForeignKey(v => v.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Vehicle)
                .WithMany()
                .HasForeignKey(b => b.VehicleId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Vehicle>()
                .HasMany(v => v.VehicleImages)
                .WithOne(i => i.Vehicle)
                .HasForeignKey(i => i.VehicleId);

            base.OnModelCreating(modelBuilder);
        }

   
        public void ReseedAllTables()
        {
            try
            {
                ReseedTable("Users", Users.Any() ? Users.Max(u => u.Id) : 0);
                ReseedTable("VehicleModels", VehicleModels.Any() ? VehicleModels.Max(vm => vm.ModelId) : 0);
                ReseedTable("VehicleCategories", VehicleCategories.Any() ? VehicleCategories.Max(vc => vc.CategoryId) : 0);
                ReseedTable("VehicleBrands", VehicleBrands.Any() ? VehicleBrands.Max(vb => vb.BrandId) : 0);
                ReseedTable("Vehicles", Vehicles.Any() ? Vehicles.Max(v => v.VehicleId) : 0);
                ReseedTable("Locations", Locations.Any() ? Locations.Max(l => l.Id) : 0);
                ReseedTable("Bookings", Bookings.Any() ? Bookings.Max(b => b.Id) : 0);
                ReseedTable("VehicleImages", VehicleImages.Any() ? VehicleImages.Max(vi => vi.Id) : 0);
            }
            catch (Exception ex)
            {
           
                Console.WriteLine($"Error reseeding tables: {ex.Message}");
            }
        }

      
        private void ReseedTable(string tableName, int maxId)
        {
            try
            {
                this.Database.ExecuteSqlRaw($"DBCC CHECKIDENT ('{tableName}', RESEED, {maxId});");
            }
            catch (Exception ex)
            {
               
                Console.WriteLine($"Error reseeding table {tableName}: {ex.Message}");
            }
        }
    }
}


