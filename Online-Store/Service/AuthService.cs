using Online_Store.Domain.Entities;
using Online_Store.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Online_Store.Models;

namespace Online_Store.Service
{
    public class AuthService
    {
        private readonly DataManager _dataManager;
        private readonly JwtService _jwtService;
        private readonly ILogger<AuthService> _logger;
        private readonly SecurePasswordHasher _passwordHasher;

        public AuthService(DataManager dataManager, JwtService jwtService, ILogger<AuthService> logger, SecurePasswordHasher securePasswordHasher) 
        {
            _dataManager = dataManager;
            _jwtService = jwtService;
            _logger = logger;
            _passwordHasher = securePasswordHasher;
        }
        public bool ValidateUser(string login, string password)
        {
            try
            {
                User user = _dataManager.Users.GetUsers().AsEnumerable().FirstOrDefault(u => u.Email.ToLower() == login.ToLower() && _passwordHasher.Verify(password, u.Password));

                if (user != null)
                {
                    if (!user.IsActive || user.IsDeleted)
                        return false;
                    return true;
                }
            }
            catch
            {
                return false;
            }
            return false;
        }
        public bool IsUserExist(string login)
        {
            try
            {
                User? user = _dataManager.Users.GetUsers().AsEnumerable().FirstOrDefault(u => u.Email.ToLower() == login.ToLower());

                if (user != null)
                {
                    if (!user.IsActive || user.IsDeleted)
                        return false;
                    return true;
                }
            }
            catch
            {
                return false;
            }
            return false;
        }
        public async Task<string> GetLoginJWTAsync(LoginViewModel login)
        {
            var User = await _dataManager.Users.GetUsers().FirstOrDefaultAsync(u => u.Email.ToLower() == login.Email.ToLower());

            var Role = await _dataManager.Roles.GetRoleByIdAsync(User.RoleId);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, User.Id.ToString()),
                new Claim(ClaimTypes.Name, User.Email),
                new Claim(ClaimTypes.Role, Role.Name)
            };

            var jwt = _jwtService.Generate(User.Id);

            return jwt.ToString();
        }
        public async Task<LoginViewModel?> SignUpAsync(RegisterViewModel register)
        {
            var role = await _dataManager.Roles.GetRoleByPriorityAsync(4);

            var user = new User
            {
                Email = register.Email,
                FirstName = register.FirstName,
                LastName = register.LastName,
                PhoneNumber = register.PhoneNumber,
                Password = _passwordHasher.Hash(register.Password),
                RoleId = role.Id
            };

            if(await _dataManager.Users.SaveUserAsync(user))
            {
                _logger.LogInformation($"Successful register! UserId: {user.Id}");
                return new LoginViewModel
                {
                    Email = user.Email,
                    Password = user.Password,
                };
            }
            else
            {
                return null;
            }
            
        }
    }
}
