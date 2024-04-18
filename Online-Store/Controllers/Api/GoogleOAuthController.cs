using Microsoft.AspNetCore.Mvc;
using Online_Store.Domain;
using Online_Store.Helpers;
using Online_Store.Models;
using Online_Store.Service;
using Online_Store.Service.Google;

namespace Online_Store.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoogleOAuthController : ControllerBase
    {
        private readonly GoogleOAuthService _googleOAuthService;
        private readonly GoogleProfileService _googleProfileService;
        private readonly DataManager _dataManager;
        private readonly AuthService _authService;
        public class Redirect
        {
            public string codeverifier { get; set; }
            public string url { get; set; }
        }
        public class ExchangeCode : Redirect
        {
            public string code { get; set; }
        }

        public GoogleOAuthController(GoogleOAuthService googleOAuthService,
                                     GoogleProfileService googleProfileService,
                                     DataManager dataManager,
                                     AuthService authService)
        {
            _googleOAuthService = googleOAuthService;
            _googleProfileService = googleProfileService;
            _dataManager = dataManager;
            _authService = authService;
        }
        [HttpGet("RedirectProfile")]
        public IActionResult RedirectOnOAuthServerProfile()
        {
            var scope = "https://www.googleapis.com/auth/userinfo.profile";

            var codeVerifier = Guid.NewGuid().ToString();

            var codeChallenge = Sha256Helper.ComputeHash(codeVerifier);

            var url = _googleOAuthService.GenerateOAuthRequestUrl(scope, "https://online-store.biz/Home", codeChallenge);

            var redirectData = new Redirect()
            {
                url = url,
                codeverifier = codeVerifier,
            };

            //return Ok(url);
            return Ok(redirectData);
        }

        [HttpPost("Code")]
        public async Task<IActionResult> CodeAsync(ExchangeCode code)
        {
            var tokenResult = await _googleOAuthService.ExchangeCodeOnTokenAsync(code.code, code.codeverifier, code.url);

            return Ok(tokenResult);
        }

        //move to accountcontroller or user
        
        private async Task<IActionResult> RegGoogleUser(GoogleUser googleUser)
        {
            var registerViewModel = new RegisterViewModel
            {
                Email = "",
                FirstName = googleUser.name,
                LastName = googleUser.family_name,
                Password = "",
                PhoneNumber = "",
                GoogleId = googleUser.id
            };

            var login = await _authService.SignUpAsync(registerViewModel);

            var user = await _dataManager.Users.GetUserByGoogleIdAsync(googleUser.id);

            user.AvatarUrl = googleUser.picture;
            user.Gender = googleUser.gender;

            await _dataManager.Users.SaveUserAsync(user);

            return Ok();
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync(TokenResult token)
        {
            var googleUser = await _googleProfileService.UserAsync(token.AccessToken);

            if (await _dataManager.Users.GetUserByGoogleIdAsync(googleUser.id) == null)
                await RegGoogleUser(googleUser);

            var user = await _dataManager.Users.GetUserByGoogleIdAsync(googleUser.id);

            return Ok(user);
        }
    }
}