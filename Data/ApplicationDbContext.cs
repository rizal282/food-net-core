using foodapi.Models;
using Microsoft.EntityFrameworkCore;

namespace foodapi.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Food> Foods { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<CategoryFood> CategoryFoods { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>().HasOne(o => o.Food).WithMany(o => o.Orders).HasForeignKey(o => o.FoodId);

        modelBuilder.Entity<Order>().HasOne(o => o.Customer).WithMany(o => o.Orders).HasForeignKey(o => o.CustomerId);

        modelBuilder.Entity<Food>().HasMany(f => f.Orders).WithOne(f => f.Food).HasForeignKey(f => f.FoodId).HasPrincipalKey(f => f.Id);

        modelBuilder.Entity<Food>().HasOne(f => f.CategoryFood).WithMany(f => f.Foods).HasForeignKey(f => f.CategoryId).HasPrincipalKey(f => f.Id);

        modelBuilder.Entity<Customer>().HasMany(c => c.Orders).WithOne(c => c.Customer).HasForeignKey(c => c.CustomerId).HasPrincipalKey(c => c.Id);
    }
}