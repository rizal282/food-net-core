using foodapi.Models;
using Microsoft.EntityFrameworkCore;

namespace foodapi.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Food> Foods { get; set; }
}