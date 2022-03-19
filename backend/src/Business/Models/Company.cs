namespace Business.Models;

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
}
