namespace Data.Entities;

internal class User
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Username { get; set; }
    public string? EmailAddress { get; set; }
    public string? Street { get; set; }
    public string? Suite { get; set; }
    public string? City { get; set; }
    public string? ZipCode { get; set; }
    public string? Longtitude { get; set; }
    public string? Latitude { get; set; }
    public string? PhoneNumber { get; set; }
    public string? CompanyName { get; set; }
    public string? CompanyCatchPhrase { get; set; }

    public List<Album>? Albums { get; set; }
    public List<Post>? Posts { get; set; }
    public List<Comment>? Comments { get; set; }
    public List<Todo>? Todos { get; set; }
}
