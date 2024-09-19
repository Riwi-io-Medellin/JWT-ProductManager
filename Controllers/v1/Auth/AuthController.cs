
using JWT_ProductManager.Config;
using JWT_ProductManager.Data;
using JWT_ProductManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace JWT_ProductManager.Controllers.v1.Auth;

[ApiController]
[Route("api/v1/[controller]")]
public class AuthController : ControllerBase
{

    private readonly ApplicationDbContext _context;
    private readonly Utilities _utilities;


    public AuthController(ApplicationDbContext context, Utilities utilities)
    {
        _context = context;
        _utilities = utilities;
    }


    [HttpPost("register")]
    public async Task<IActionResult> Register(User newUser)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        if (_context.Users.Any(u => u.Email == newUser.Email))
        {
            return BadRequest("Email already exists");
        }

        newUser.Password = _utilities.EncryptSHA256(newUser.Password);

        _context.Users.Add(newUser);
        await _context.SaveChangesAsync();
        return Ok("User registered successfully");
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login()
    {
        // Login logic here
        return Ok("Login");
    }

}
