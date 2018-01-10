using Microsoft.AspNetCore.Mvc;

namespace rlara.prototypes.web.ViewComponents
{
    public class AdminNavViewComponent:ViewComponent
    {
        public AdminNavViewComponent()
        {
            
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}