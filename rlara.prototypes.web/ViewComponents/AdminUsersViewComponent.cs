using Microsoft.AspNetCore.Mvc;

namespace rlara.prototypes.web.ViewComponents
{
    public class AdminUsersViewComponent:ViewComponent
    {
        public AdminUsersViewComponent()
        {
            
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}