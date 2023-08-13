using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Online_Store.Domain;
using System.Security.Claims;

namespace Online_Store.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController: ControllerBase
    {
        private DataManager _dataManager { get; set; }
        public UserController(DataManager dataManager) 
        {
            _dataManager = dataManager;
        }

        [HttpGet("current-user")]
        [Authorize]
        public async Task<IActionResult> GetCurrentUserInfo()
        {
            var userIdClaim = User.Claims.FirstOrDefault(claim => claim.Type == ClaimTypes.NameIdentifier);

            if (userIdClaim != null && Guid.TryParse(userIdClaim.Value, out Guid userId))
            {
                var user = await _dataManager.Users.GetUserByIdAsync(userId);
                var Role = user.UserRoles.OrderBy(x => x.Role.Priority).FirstOrDefault().Role;

                return Ok(new
                {
                    email = user.Email,
                    firstname = user.FirstName,
                    lastname = user.LastName,
                    gender = user.Gender
                });
            }
            else
            {
                return BadRequest("Unable to retrieve current user information.");
            }
        }
    }
}
