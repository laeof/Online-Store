using Microsoft.AspNetCore.Mvc;
using Online_Store.Models;
using Online_Store.Domain;

namespace Online_Store.Components
{
    public class HeaderViewComponent: ViewComponent
    {
        private readonly UserManager userManager;
        private readonly DataManager dataManager;
        public HeaderViewComponent(UserManager userManager, DataManager dataManager)
        {
            this.userManager = userManager;
            this.dataManager = dataManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = new HeaderViewModel
            {
                User = userManager.User,
                Role = userManager.User.UserRoles.OrderBy(x => x.Role.Priority).FirstOrDefault().Role
            };

            return View(model);
        }
    }
}
