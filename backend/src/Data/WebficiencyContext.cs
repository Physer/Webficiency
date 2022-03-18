using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Data;

public class WebficiencyContext : DbContext
{
    public DbSet<User>? Users { get; set; }
    public DbSet<Album>? Albums { get; set; }
    public DbSet<Comment>? Comments { get; set; }
    public DbSet<Photo>? Photos { get; set; }
    public DbSet<Post>? Posts { get; set; }
    public DbSet<Todo>? Todos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configuration = ConfigurationHelper.GetConfiguration();
        optionsBuilder.UseSqlite(configuration.GetConnectionString("WebficiencyDatabase"));
    }
}
