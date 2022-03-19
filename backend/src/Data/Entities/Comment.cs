namespace Data.Entities;

public class Comment
{
    public Comment(string name, string body)
    {
        Name = name;
        Body = body;
    }

    public Comment(string name, string? email, string body) : this(name, email)
    {
        Body = body;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string? Email { get; set; }
    public string Body { get; set; }
}
