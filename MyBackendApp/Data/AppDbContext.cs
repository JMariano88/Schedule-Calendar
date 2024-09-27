using Microsoft.EntityFrameworkCore;

namespace YourAppNamespace.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // DbSets for each table
        public DbSet<Models.User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Fluent API configurations

        // Unique constraint on Username and Email
        modelBuilder.Entity<Models.User>()
            .HasIndex(u => u.Username)
            .IsUnique();

        modelBuilder.Entity<Models.User>()
            .HasIndex(u => u.Email)
            .IsUnique();

        // Check constraint on Role
        modelBuilder.Entity<Models.User>()
            .HasCheckConstraint("CK_User_Role", "[Role] IN ('Developer', 'Customer')");
    }
        public DbSet<Models.Availability> Availabilities { get; set; }
        public DbSet<Models.Meeting> Meetings { get; set; }
        public DbSet<Models.Project> Projects { get; set; }
        public DbSet<Models.ProjectProgress> ProjectProgresses { get; set; }

    }
}
