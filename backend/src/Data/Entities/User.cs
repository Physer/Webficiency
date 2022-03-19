namespace Data.Entities;

public class User
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Username { get; set; }
    public string? EmailAddress { get; set; }
    public string? PhoneNumber { get; set; }

    public List<Album>? Albums { get; set; }
    public List<Post>? Posts { get; set; }
    public List<Comment>? Comments { get; set; }
    public List<Todo>? Todos { get; set; }

    public Address? Address { get; set; }
    public Company? Company { get; set; }
}
