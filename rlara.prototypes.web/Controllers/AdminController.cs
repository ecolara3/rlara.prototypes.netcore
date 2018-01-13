using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace rlara.prototypes.web.Controllers
{
    public class AdminController : Controller
    {
        
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View();
        }
        
        
        
    }
}