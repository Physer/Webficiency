namespace Data.Entities;

public class Address
{
    public long Id { get; set; }
    public string? Street { get; set; }
    public string? Suite { get; set; }
    public string? City { get; set; }
    public string? ZipCode { get; set; }
    public string? Longitude { get; set; }
    public string? Latitude { get; set; }

    public int UserId { get; set; }
    public User? User { get; set; }
}