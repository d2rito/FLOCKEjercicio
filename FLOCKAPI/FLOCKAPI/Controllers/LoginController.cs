using FLOCKAPI.Classes;
using Microsoft.AspNetCore.Mvc;

namespace FLOCKAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly ILogger <LoginController> _logger;
        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public async Task<IActionResult> Login(string username, string password)
        {
            User user = new User { UserName = username, Password = password};
            user.ValidateUser();
            _logger.LogInformation("Se valida que el usuario esté en la 'base'");
            if (user.Enabled)
                return Ok();
            _logger.LogError("El usuario no esta registrado");
            return BadRequest();
        }
    }
}
