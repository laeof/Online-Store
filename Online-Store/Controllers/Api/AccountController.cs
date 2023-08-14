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
using Online_Store.Service;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Online_Store.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private DataManager _dataManager;
        private ILogger<AccountController> _logger;
        private JwtService _jwtService;
        private AuthService _authService;

        public AccountController(DataManager dataManager,
                                ILogger<AccountController> logger,
                                JwtService jwtService,
                                AuthService authService)
        {
            _dataManager = dataManager;
            _logger = logger;
            _jwtService = jwtService;
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterViewModel register)
        {
            //user exists

            if (_authService.IsUserExist(register.Email))
            {
                _logger.LogError("Register error (user exists)");
                return BadRequest();
            }

            //singup and login

            LoginViewModel? login = await _authService.SignUpAsync(register);

            if(login == null)
            {
                _logger.LogError("Register error (fail to save user)");
                return BadRequest();
            }

            //login with jwt
            
            string jwt = await _authService.GetLoginJWTAsync(login);

            var User = await _dataManager.Users.GetUsers().FirstOrDefaultAsync(u => u.Email.ToLower() == login.Email);

            _logger.LogInformation("Successful login, " + User.Id);

            Response.Cookies.Append("jwtToken", jwt, new CookieOptions
            {
                HttpOnly = true,
                Expires = DateTimeOffset.UtcNow.AddDays(2)
            });

            return Ok();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginViewModel login)
        {
            if (!_authService.ValidateUser(login.Email, login.Password))
            {
                _logger.LogError("Login error (password incorrect or user with this email does not exist)");
                return BadRequest();
            }

            string jwt = await _authService.GetLoginJWTAsync(login);

            User User = await _dataManager.Users.GetUsers().FirstOrDefaultAsync(u => u.Email.ToLower() == login.Email);

            _logger.LogInformation("Successful login, " + User.Id);

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
            _logger.LogInformation("User logged out");
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
                var validatedToken = _jwtService.Verify(jwtToken);

                return Ok(true);
            }
            catch
            {
                return Ok(false);
            }
        }

    }
}
