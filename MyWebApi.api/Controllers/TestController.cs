using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace MyWebApi.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    [HttpGet("gizli-veri")]
    [Authorize]
    public IActionResult GizliVeri()
    {
        var username = User.FindFirstValue(ClaimTypes.Name);
        return Ok(new { mesaj = $"Merhaba {username}, bu veriyi sadece giriş yapmış kullanıcılar görebilir." });
    }
}