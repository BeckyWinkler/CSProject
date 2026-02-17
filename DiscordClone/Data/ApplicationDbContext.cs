using Microsoft.EntityFrameworkCore;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
  
    }
        // Add DbSet properties for your database tables/entities here
        // public DbSet<User> Users { get; set; }
}
