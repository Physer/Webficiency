namespace Data.Entities;

public class Post
{
    public Post(string body, string title)
    {
        Body = body;
        Title = title;
    }

    public Guid Id { get; set; }
    public string Body { get; set; }
    public string Title { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; } = null!;
}
