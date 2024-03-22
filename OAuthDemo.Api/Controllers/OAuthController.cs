using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace OAuthDemo.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class OAuthController : ControllerBase
{
    [HttpGet("login")]
    public IActionResult Login()
    {
        var authenticationProperties = new AuthenticationProperties { RedirectUri = "/" };
        return Challenge(authenticationProperties, GoogleDefaults.AuthenticationScheme);
    }
}
