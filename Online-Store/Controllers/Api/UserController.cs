using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;
using Microsoft.IdentityModel.Tokens;
using Online_Store.Domain;
using Online_Store.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Online_Store.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController: ControllerBase
    {
        private DataManager _dataManager { get; set; }
        private JwtService _jwtService { get; set; }
        public UserController(DataManager dataManager, JwtService jwtService) 
        {
            _dataManager = dataManager;
            _jwtService = jwtService;
        }

        [HttpGet("current-user")]
        public async Task<IActionResult> GetCurrentUserInfo()
        {
            if (!HttpContext.Request.Cookies.TryGetValue("jwtToken", out var jwtToken))
            {
                return Unauthorized();
            }

            var userId = _jwtService.GetUserIdFromToken(jwtToken);

            if (userId == null)
            {
                return BadRequest("Unable to retrieve current user information.");
            }

            var user = await _dataManager.Users.GetUserByIdAsync((Guid)userId);
            var Role = _dataManager.UserRoles.GetUserRole().Where(x => x.UserId == user.Id).OrderBy(x => x.Role.Priority).FirstOrDefault().Role;

            return Ok(new CabinetViewModel
            {
                Role = Role.Name,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Gender = user.Gender,
                PhoneNumber = user.PhoneNumber,
            });
        }
    }
}
