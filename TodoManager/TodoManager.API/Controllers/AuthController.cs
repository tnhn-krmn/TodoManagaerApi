using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TodoManager.Business.Abstract;
using TodoManager.Entities.Concrete;

namespace TodoManager.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly IJwtAuthenticationService _jwtAuthenticationService;

        public AuthController(IJwtAuthenticationService jwtAuthenticationService)
        {
            _jwtAuthenticationService = jwtAuthenticationService;
        }

        [AllowAnonymous]
        [HttpPost("Authenticate")]
        public IActionResult Authenticate([FromBody] User user)
        {
            // throw new Exception("No entered!");

            var IsUser = _jwtAuthenticationService.Authenticate(user.UserName,user.Password);

            if (IsUser == null)
            {
                return BadRequest("Hatalı bilgi");
            }
            return Ok(IsUser);
        }
    }
}
