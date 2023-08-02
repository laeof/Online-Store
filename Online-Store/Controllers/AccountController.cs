using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Store.Domain;
using Online_Store.Domain.Repository.EntityFramework;
using Online_Store.Models;
using System.ComponentModel.DataAnnotations;

namespace Online_Store.Controllers
{
    public class AccountController: Controller
	{
		private readonly DataManager dataManager;
		private readonly UserManager userManager;
        private readonly ILogger<AccountController> logger;
        public AccountController(DataManager dataManager, UserManager userManager, ILogger<AccountController> logger)
		{
			this.dataManager = dataManager;
			this.userManager = userManager;
			this.logger = logger;
		}

		[HttpGet]
		[AllowAnonymous]
		public IActionResult Login()
		{
			if (userManager.User != null)
			{
				return Redirect("/Account/PersonalPage");
			}
			return View(new LoginViewModel());
		}

		[HttpPost]
		[AllowAnonymous]
		public async Task<IActionResult> Login(LoginViewModel model)
		{
			if (ModelState.IsValid)
			{
				if (await Extensions.ValidateUser(model.Email, model.Password, dataManager))
				{
					logger.LogInformation($"User with UserId {dataManager.Users.GetUsers().FirstOrDefault(x => x.Email.ToLower() == model.Email.ToLower()).Id} is signed in.");
					
					await userManager.SignInAsync(model.Email);

					//редіректи

					return Redirect("/Home/");
				}
				model.ErrorMessage = "";
            }
            return View(new LoginViewModel());
        }

		[Authorize]
		public async Task<IActionResult> Logout()
		{
			await userManager.SignOutAsync();
			return RedirectToAction("Login");
		}

		[HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
		{
            if (userManager.User != null)
            {
                return Redirect("/Account/PersonalPage");
            }
            return View(new RegisterViewModel());
		}

		[HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel model)
		{

			if (ModelState.IsValid)
			{
				//check for existing
				var existingUser = await dataManager.Users.GetUsers().FirstOrDefaultAsync(u => u.Email.ToLower() == model.Email.ToLower());
				if (existingUser != null)
				{
					ModelState.AddModelError(string.Empty, "Користувач з таким логіном вже існує");
					return View(model);
				}

				await userManager.SingUpAsync(model);

                // redirect to home page
                return Redirect("/Home/");
            }

            return View(new RegisterViewModel());
        }
	}
}
