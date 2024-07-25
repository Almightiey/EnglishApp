using System.ComponentModel.DataAnnotations;

namespace Application.Handlers.User;

public class LoginRequest
{
    [Required]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }
}
