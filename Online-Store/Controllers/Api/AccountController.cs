using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using NuGet.Protocol.Core.Types;
using NuGet.Protocol.Plugins;
using Online_Store.Domain;
using Online_Store.Domain.Entities;
using Online_Store.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Online_Store.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private DataManager dataManager;
        private ILogger<AccountController> logger;
        private UserManager userManager;
        private JwtService jwtService;

        [HttpPost("register")]
        public async Task<IActionResult> Register(Guid id)
        {
            return Ok();
        }

        public AccountController(DataManager dataManager, ILogger<AccountController> logger, UserManager userManager,
            JwtService jwtService)
        {
            this.dataManager = dataManager;
            this.logger = logger;
            this.userManager = userManager;
            this.jwtService = jwtService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginViewModel login)
        {
            if (!(await Extensions.ValidateUser(login.Email, login.Password, dataManager)))
            {
                logger.LogError("Login error");
                return BadRequest();
            }

            var User = await dataManager.Users.GetUsers().FirstOrDefaultAsync(u => u.Email.ToLower() == login.Email.ToLower());

            var Role = User.UserRoles.OrderBy(x => x.Role.Priority).FirstOrDefault().Role;

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, User.Id.ToString()),
                new Claim(ClaimTypes.Name, User.Email),
                new Claim(ClaimTypes.Role, Role.Name)
            };

            var jwt = jwtService.Generate(User.Id);

            Response.Cookies.Append("jwt", jwt, new CookieOptions
            {
                HttpOnly = true,
            });

            logger.LogInformation("Successful login, " + User.Id);

            return Ok(new
            {
                message = "success"
            });
        }

        [HttpGet("user")]
        public async Task<IActionResult> User()
        {
            var jwt = Request.Cookies["jwt"];
            if (jwt != null)
            {
                var token = jwtService.Verify(jwt);

                Guid userId = Guid.Parse(token.Issuer);

                var user = await dataManager.Users.GetUserByIdAsync(userId);

                return Ok(user);
            }
            else
            {
                logger.LogInformation("No jwt token, need to authorize");
                return BadRequest();
            }

        }

        [HttpPost("logout")]
        public IActionResult LogOut()
        {
            Response.Cookies.Delete("jwt");
            logger.LogInformation("User logged out");
            return Ok(new
            {
                message = "logout"
            });
        }

    }
}
