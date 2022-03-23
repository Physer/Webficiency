namespace Business.External;

internal class TypicodeUserDto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Username { get; set; }
    public string? Email { get; set; }
    public TypicodeAddressDto? Address { get; set; }
    public string? Phone { get; set; }
    public string? Website { get; set; }
    public TypicodeCompanyDto? Company { get; set; }
}
