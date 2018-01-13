using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using rlara.prototypes.identity.Entities;

namespace rlara.prototypes.web.ViewComponents
{
    public class AdminUsersViewComponent:ViewComponent
    {
        private readonly UserManager<User> _userManager;
        public AdminUsersViewComponent(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
            List<User> users = _userManager.Users.ToList();
            
            return View(users);
        }
    }
}