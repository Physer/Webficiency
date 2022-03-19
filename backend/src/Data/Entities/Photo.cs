namespace Data.Entities;

public class Photo
{
    public Photo(string title, string url)
    {
        Title = title;
        Url = url;
    }

    public Photo(string title, string url, string? thumbnailUrl) : this(title, url)
    {
        ThumbnailUrl = thumbnailUrl;
    }

    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Url { get; set; }
    public string? ThumbnailUrl { get; set; }

    public Guid AlbumId { get; set; }
    public Album Album { get; set; } = null!;
}
