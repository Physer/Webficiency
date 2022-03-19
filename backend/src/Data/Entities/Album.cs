namespace Data.Entities;

public class Album
{
    public Album(string title)
    {
        Title = title;
    }

    public Guid Id { get; set; }
    public string Title { get; set; }

    public List<Photo> Photos { get; set; } = new();
}
