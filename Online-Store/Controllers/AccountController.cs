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

                return View(new LoginViewModel() { ErrorMessage = "Невірно введено Email або пароль" });
            }

            return View(new LoginViewModel() { ErrorMessage = "Всі поля мають бути заповненими." });
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
				var existingUser = await dataManager.Users.GetUsers().FirstOrDefaultAsync(u => (u.Email.ToLower() == model.Email.ToLower()) || (u.PhoneNumber == model.PhoneNumber));
				if (existingUser != null)
				{
                    model.ErrorMessage = "Такий користувач вже існує.";
                    return View(model);
				}

				await userManager.SingUpAsync(model);

                // redirect to home page
                return Redirect("/Home/");
            }

            return View(new RegisterViewModel() { ErrorMessage = "Всі поля мають бути заповненими." });
        }

		[HttpGet]
		[Authorize]
		public IActionResult Cabinet()
		{
			return View(new CabinetViewModel()
			{
				FirstName = userManager.User.FirstName,
				LastName = userManager.User.LastName,
				Email = userManager.User.Email,
				PhoneNumber = userManager.User.PhoneNumber,
				Gender = userManager.User.Gender
			});
		}
	}
}
