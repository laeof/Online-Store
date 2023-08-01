using Microsoft.AspNetCore.Mvc;
using Online_Store.Domain;
using Online_Store.Models;

namespace Online_Store.Components
{
    public class LoginViewComponent: ViewComponent
    {
        private readonly UserManager userManager;
        public LoginViewComponent(UserManager userManager)
        {
            this.userManager = userManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(new LoginViewModel());
        }
    }
}
