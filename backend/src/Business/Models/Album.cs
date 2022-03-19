namespace Business.Models;

public class Album
{
    public Album(string title)
    {
        Title = title;
    }

    public string Title { get; set; }

    public List<Photo> Photos { get; set; } = new();
}
