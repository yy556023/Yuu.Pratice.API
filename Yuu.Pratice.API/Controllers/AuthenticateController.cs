using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Yuu.Pratice.API.Controllers;

[Route("api/auth")]
[ApiController]
public class AuthenticateController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly SignInManager<IdentityUser> _signInManager;

    public AuthenticateController(
        IConfiguration configuration,
        UserManager<IdentityUser> userManager,
        SignInManager<IdentityUser> signInManager
    )
    {
        _configuration = configuration;
        _userManager = userManager;
        _signInManager = signInManager;
    }

    [HttpPost("login")]
    [AllowAnonymous]
    public IActionResult Login([FromBody] string a)
    {
        return Ok();
    }
}
