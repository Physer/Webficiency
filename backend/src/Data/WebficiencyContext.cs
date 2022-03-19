using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class WebficiencyContext : DbContext
{
    private readonly string _dbPath;

    public DbSet<User>? Users { get; set; }
    public DbSet<Album>? Albums { get; set; }
    public DbSet<Comment>? Comments { get; set; }
    public DbSet<Photo>? Photos { get; set; }
    public DbSet<Post>? Posts { get; set; }
    public DbSet<Todo>? Todos { get; set; }

    public WebficiencyContext()
    {
        var configuration = ConfigurationHelper.GetConfiguration();
        if (!bool.TryParse(configuration["InMemoryDatabase"], out var useInMemoryDatabase))
            throw new ArgumentException("Invalid configuration");
        if (useInMemoryDatabase)
            _dbPath = ":memory:";
        else
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            _dbPath = Path.Join(path, "webficiency.db");
        }
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite($"Data Source={_dbPath}");
}
