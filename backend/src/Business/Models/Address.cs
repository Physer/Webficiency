namespace Business.Models;

public class Address
{
    public Address(string street, string city)
    {
        Street = street;
        City = city;
    }

    public Address(string street, string? suite, string city, string? zipCode, string? longitude, string? latitude) : this(street, city)
    {
        Suite = suite;
        ZipCode = zipCode;
        Longitude = longitude;
        Latitude = latitude;
    }

    public string Street { get; set; }
    public string? Suite { get; set; }
    public string City { get; set; }
    public string? ZipCode { get; set; }
    public string? Longitude { get; set; }
    public string? Latitude { get; set; }
}