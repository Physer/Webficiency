namespace Data.Entities;

public class Company
{
    public string? Name { get; set; }
    public string? CatchPhrase { get; set; }

    public int UserId { get; set; }
    public User? User { get; set; }
}
