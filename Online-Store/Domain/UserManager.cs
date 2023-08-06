using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Online_Store.Domain.Entities;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using Online_Store.Models;
using Microsoft.AspNetCore.Identity;

namespace Online_Store.Domain
{
	public class UserManager
	{
		private readonly DataManager dataManager;
		private readonly IHttpContextAccessor httpContextAccessor;
		public User User { get; }
		public UserManager(DataManager dataManager, IHttpContextAccessor httpContextAccessor)
		{
			this.dataManager = dataManager;
			this.httpContextAccessor = httpContextAccessor;
			if (httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
			{
				this.User = dataManager.Users.GetUsers()
				.Include(ur => ur.UserRoles)
					.ThenInclude(r => r.Role)
                .AsNoTracking()
				.FirstOrDefault(u => u.Id ==
					Guid.Parse(httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value));
			}
		}

		public async Task<bool> SignInAsync(string login)
		{
			if (login == null)
				return false;

			var User = await dataManager.Users.GetUsers().FirstOrDefaultAsync(u => u.Email.ToLower() == login.ToLower());

			var Role = User.UserRoles.OrderBy(x => x.Role.Priority).FirstOrDefault().Role;

			var claims = new List<Claim>
			{
				new Claim(ClaimTypes.NameIdentifier, User.Id.ToString()),
				new Claim(ClaimTypes.Name, User.Email),
				new Claim(ClaimTypes.Role, Role.Name)
			};

			var identity = new ClaimsIdentity(claims, "Auth");
			var principal = new ClaimsPrincipal(identity);

			await httpContextAccessor.HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

			return true;
		}
		public async Task<bool> SignInByApiKeyAsync(string apiKey)
		{
			var user = await dataManager.Users.GetUsers().FirstOrDefaultAsync(u => u.ApiKey == apiKey);
			if (user == null)
			{
				return false;
			}
			var success = await SignInAsync(user.Email);

			if (success)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public async Task<bool> SignOutAsync()
		{
			await httpContextAccessor.HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
			return true;
		}
		public async Task<bool> SingUpAsync(RegisterViewModel model)
		{

			// create user
			var user = new User
			{
				FirstName= model.Name,
				LastName= model.Lastname,
				Email = model.Email,
				Password = SecurePasswordHasher.Hash(model.Password),
				PhoneNumber = model.PhoneNumber,
			};

			//save user
			await dataManager.Users.SaveUserAsync(user);

			var role = await dataManager.Roles.GetRoleByPriorityAsync(4);

			// create role for user
			var userrole = new UserRole
			{
				UserId = user.Id,
				RoleId = role.Id
			};

			//save user role to db

			await dataManager.UserRoles.SaveUserRoleAsync(userrole);

			await SignInAsync(user.Email);

			return true;
		}
	}
}
