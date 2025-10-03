using GamerStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GamerStore.Infrastructure.Data;

public class GamerStoreDbContext(DbContextOptions<GamerStoreDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<CartItem> CartItems { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>()
            .Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(100);

        base.OnModelCreating(modelBuilder);
    }
}
