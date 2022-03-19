namespace Business.Models;

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

    public string Title { get; set; }
    public string Url { get; set; }
    public string? ThumbnailUrl { get; set; }
}
