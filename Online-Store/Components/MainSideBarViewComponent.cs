using Microsoft.AspNetCore.Mvc;
using Online_Store.Models;
using Online_Store.Domain;

namespace Online_Store.Components
{
    public class MainSideBarViewComponent: ViewComponent
    {
        private readonly UserManager userManager;
        public MainSideBarViewComponent(UserManager userManager)
        {
            this.userManager = userManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(new MainSideBarViewModel
            {
                FirstName = userManager.User.FirstName,
                LastName = userManager.User.LastName,
                ImgPath = userManager.User.AvatarUrl
            });
        }
    }
}
