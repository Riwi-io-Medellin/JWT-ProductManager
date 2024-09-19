using System.ComponentModel.DataAnnotations;

namespace JWT_ProductManager.Requests;
public class LoginRequest
{
    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid email address format.")]
    [MaxLength(100, ErrorMessage = "Email must be at most {1} characters.")]
    public required string Email { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    [MinLength(8, ErrorMessage = "Password must be at least {1} characters.")]
    public required string Password { get; set; }

}
