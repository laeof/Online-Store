using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Online_Store.Domain;
using Online_Store.Models;
using Online_Store.Service;

namespace Online_Store.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataManager _dataManager;
        private readonly JwtService _jwtService;
        private readonly GoogleProfileService _googleProfileService;
        public UserController(DataManager dataManager, 
                              JwtService jwtService,
                              GoogleProfileService googleProfileService)
        {
            _dataManager = dataManager;
            _jwtService = jwtService;
            _googleProfileService = googleProfileService;
        }

        [HttpGet("current-user")]
        public async Task<IActionResult> GetCurrentUserInfo()
        {
            string jwtToken = null;
            string accessToken = null;
            Guid? userId = null;

            if (!HttpContext.Request.Cookies.TryGetValue("jwtToken", out jwtToken) &&
                !HttpContext.Request.Cookies.TryGetValue("accessToken", out accessToken))
            {
                return Unauthorized();
            }

            if (accessToken != null)
            {
                userId = await GetUserGoogleOAuth(accessToken);
            }
            else if (jwtToken != null)
            {
                userId = await GetUserJwtToken(jwtToken);
            }

            if(userId == null)
                return Unauthorized();

            var user = await _dataManager.Users.GetUserByIdAsync((Guid)userId);

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

        public async Task<Guid> GetUserJwtToken(string jwtToken)
        {
            return (Guid)_jwtService.GetUserIdFromToken(jwtToken);
        }

        public async Task<Guid> GetUserGoogleOAuth(string access_token)
        {
            return await _googleProfileService.GetUserIdAsync(await _googleProfileService.UserAsync(access_token));
        }
    }
}
