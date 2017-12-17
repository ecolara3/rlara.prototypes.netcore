using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using rlara.prototypes.data.Entities;

namespace rlara.prototypes.data
{
    public class StoreDBContext:IdentityDbContext<User, Role, string>
    {
        public StoreDBContext(DbContextOptions<StoreDBContext> options)
            : base(options)
        {
            
        }
        
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Image> Image { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Image>();
            modelBuilder.Entity<Product>();
            modelBuilder.Entity<Category>();
            
        }

    }
}