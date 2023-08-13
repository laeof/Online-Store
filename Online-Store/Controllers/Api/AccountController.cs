using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using NuGet.Common;
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
        private JwtService jwtService;

        [HttpPost("register")]
        public async Task<IActionResult> Register(Guid id)
        {
            return Ok();
        }

        public AccountController(DataManager dataManager,
                                ILogger<AccountController> logger,
                                JwtService jwtService)
        {
            this.dataManager = dataManager;
            this.logger = logger;
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

            logger.LogInformation("Successful login, " + User.Id);

            Response.Cookies.Append("jwtToken", jwt, new CookieOptions
            {
                HttpOnly = true,
                Expires = DateTimeOffset.UtcNow.AddDays(2)
            });

            return Ok();
        }

        [HttpPost("logout")]
        public IActionResult LogOut()
        {
            logger.LogInformation("User logged out");
            Response.Cookies.Delete("jwtToken");
            return Ok();
        }
        [HttpGet("check-auth")]
        public IActionResult CheckAuthorization()
        {
            if (!HttpContext.Request.Cookies.TryGetValue("jwtToken", out var jwtToken))
            {
                return Unauthorized();
            }

            try
            {
                var validatedToken = jwtService.Verify(jwtToken);

                return Ok(true);
            }
            catch
            {
                return Ok(false);
            }
        }

    }
}
