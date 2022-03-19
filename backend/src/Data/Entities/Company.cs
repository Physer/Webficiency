namespace Data.Entities;

public class Company
{
    public Company(string name)
    {
        Name = name;
    }

    public Company(string name, string? catchPhrase) : this(name)
    {
        CatchPhrase = catchPhrase;
    }

    public string Name { get; set; }
    public string? CatchPhrase { get; set; }

    public int UserId { get; set; }
    public User User { get; set; } = null!;
}
