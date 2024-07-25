namespace Application.Handlers.User;

public record class UserDto
{
    public string Id { get; init; }
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public string Email { get; init; }
    public string UserName { get; init; }
    public string? Role { get; init; }
    public List<string>? Roles { get; set; }
}
