namespace Application.Settings;

public class JwtSettings
{
    public const string SectionName = nameof(JwtSettings);
    public string Key { get; init; } = null!;
    public int ExpiryMinutes { get; init; }
    public string Issuer { get; init; } = null!;
    public string Audience { get; init; } = null!;
}
