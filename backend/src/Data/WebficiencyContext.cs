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
        _connectionString = ConfigurationHelper.GetSqliteConnectionString();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite(_connectionString);
}
