using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class WebficiencyContext : DbContext
{
    private readonly string _connectionString;

    public DbSet<User>? Users { get; set; }
    public DbSet<Album>? Albums { get; set; }
    public DbSet<Comment>? Comments { get; set; }
    public DbSet<Photo>? Photos { get; set; }
    public DbSet<Post>? Posts { get; set; }
    public DbSet<Todo>? Todos { get; set; }

    public WebficiencyContext()
    {
        _connectionString = ConfigurationHelper.Instance.GetSqliteConnectionString();
    }

    public WebficiencyContext(DbContextOptions<WebficiencyContext> options)
        : base(options)
    {
        _connectionString = ConfigurationHelper.Instance.GetSqliteConnectionString();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite(_connectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasOne(u => u.Address).WithOne(a => a.User);
        modelBuilder.Entity<User>().HasOne(u => u.Company).WithOne(c => c.User);
        modelBuilder.Entity<User>().HasMany(u => u.Albums).WithOne(a => a.User);
        modelBuilder.Entity<User>().HasMany(u => u.Posts).WithOne(p => p.User);
        modelBuilder.Entity<User>().HasMany(u => u.Comments).WithOne(c => c.User);
        modelBuilder.Entity<User>().HasMany(u => u.Todos).WithOne(t => t.User);

        modelBuilder.Entity<Album>().HasMany(a => a.Photos).WithOne(p => p.Album);
    }
}
