namespace Business.Models;

public class Post
{
    public Post(string body, string title)
    {
        Body = body;
        Title = title;
    }

    public string Body { get; set; }
    public string Title { get; set; }
}
