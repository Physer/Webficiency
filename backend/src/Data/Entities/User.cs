namespace Data.Entities;

public class User
{
    public User(string username, string emailAddress)
    {
        Username = username;
        EmailAddress = emailAddress;
    }

    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string Username { get; set; }
    public string EmailAddress { get; set; }
    public string? PhoneNumber { get; set; }

    public List<Album> Albums { get; set; } = new();
    public List<Post> Posts { get; set; } = new();
    public List<Comment> Comments { get; set; } = new();
    public List<Todo> Todos { get; set; } = new();

    public Address Address { get; set; } = null!;
    public Company Company { get; set; } = null!;
}
