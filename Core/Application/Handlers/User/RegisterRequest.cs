using System.ComponentModel.DataAnnotations;

namespace Application.Handlers.User;

public class RegisterRequest
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    [MinLength(4)]
    public string UserName { get; set; }

    [Required]
    [MinLength(5)]
    public string Password { get; set; }

    [Required]
    [Compare("Password")]
    public string ConfirmPassword { get; set; }
}
