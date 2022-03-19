namespace Business.Models;

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

    public string Name { get; set; }
    public string? Email { get; set; }
    public string Body { get; set; }
}
