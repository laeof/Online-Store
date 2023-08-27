using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Online_Store.Domain;
using Online_Store.Models;
using Online_Store.Service;

namespace Online_Store.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController: ControllerBase
    {
        private readonly DataManager _dataManager;
        private readonly JwtService _jwtService;
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

            var user = await _dataManager.Users.GetUserByIdAsync((Guid)userId);

            if (user == null)
            {
                return Unauthorized();
            }

            var role = await _dataManager.Roles.GetRoleByIdAsync(user.RoleId);

            return Ok(new CabinetViewModel
            {
                Id = user.Id,
                Role = role.Name,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Gender = user.Gender,
                PhoneNumber = user.PhoneNumber,
            });
        }
    }
}
