using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using News.DTOs;
using News.Services;

namespace News_Application.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public LoginController(ILoginService service)
        {
            Service = service;
        }

        public ILoginService Service { get; }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginDto dto)
        {
    
            if (dto != null)
            {
                var res = await Service.LoginAsync(dto);
                return Ok(new {res});
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
