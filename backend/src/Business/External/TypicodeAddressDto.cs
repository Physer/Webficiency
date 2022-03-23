namespace Business.External;

internal class TypicodeAddressDto
{
    public string? Street { get; set; }
    public string? Suite { get; set; }
    public string? City { get; set; }
    public string? Zipcode { get; set; }
    public TypicodeGeoDto? Geo { get; set; }
}
