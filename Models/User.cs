using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JWT_ProductManager.Models;

[Table("users")]
public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id", Order = 1)]
    public int Id { get; set; }

    [Required(ErrorMessage = "First name is required.")]
    [MinLength(2, ErrorMessage = "First name must be at least {1} characters.")]
    [MaxLength(50, ErrorMessage = "First name must be at most {1} characters.")]
    [Column("name", Order = 2)]
    public required string Name { get; set; }

    [Required(ErrorMessage = "Last name is required.")]
    [MinLength(2, ErrorMessage = "Last name must be at least {1} characters.")]
    [MaxLength(50, ErrorMessage = "Last name must be at most {1} characters.")]
    [Column("last_name", Order = 3)]
    public required string LastName { get; set; }

    [Required(ErrorMessage = "Username is required.")]
    [MinLength(3, ErrorMessage = "Username must be at least {1} characters.")]
    [MaxLength(30, ErrorMessage = "Username must be at most {1} characters.")]
    [Column("username", Order = 4)]
    public required string Username { get; set; }

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid email address format.")]
    [MaxLength(100, ErrorMessage = "Email must be at most {1} characters.")]
    [Column("email", Order = 5)]
    public required string Email { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    [MinLength(8, ErrorMessage = "Password must be at least {1} characters.")]
    [Column("password", Order = 6)]
    public required string Password { get; set; }
}

