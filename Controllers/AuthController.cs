using Microsoft.AspNetCore.Mvc;
using NetCoreRestStarter.Api.Data;
using NetCoreRestStarter.Api.Models;
using NetCoreRestStarter.Api.Services;

namespace NetCoreRestStarter.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly JwtService _jwt;

    public AuthController(AppDbContext context, JwtService jwt)
    {
        _context = context;
        _jwt = jwt;
    }

    [HttpPost("register")]
    public IActionResult Register(User user)
    {
        user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(user.PasswordHash);
        _context.Users.Add(user);
        _context.SaveChanges();
        return Ok(user);
    }

    [HttpPost("login")]
    public IActionResult Login(User user)
    {
        var dbUser = _context.Users.FirstOrDefault(x => x.Username == user.Username);
        if (dbUser == null || !BCrypt.Net.BCrypt.Verify(user.PasswordHash, dbUser.PasswordHash))
            return Unauthorized();

        var token = _jwt.GenerateToken(dbUser);
        return Ok(new { token });
    }
}
