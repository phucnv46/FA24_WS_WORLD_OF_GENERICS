using Microsoft.EntityFrameworkCore;
using World_Of_Generics_API.Models;

namespace World_Of_Generics_API.Data
{
    public class StoreDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public StoreDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(Seeding.Products);
            modelBuilder.Entity<Category>().HasData(Seeding.Categories);
            base.OnModelCreating(modelBuilder);
        }
    }
}
