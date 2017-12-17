using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using rlara.prototypes.data.Entities;
using rlara.prototypes.web.ViewModels;

namespace rlara.prototypes.web.Controllers
{
    public class AccountController:Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _loginManager;
        private readonly RoleManager<Role> _roleManager;

        public AccountController(UserManager<User> userManager,SignInManager<User> loginManager,RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _loginManager = loginManager;
            _roleManager = roleManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel obj)
        {

            if (ModelState.IsValid)
            {
                User user = new User();
                user.UserName = obj.UserName;
                user.Email = obj.Email;
                user.FullName = obj.FullName;
                user.Birthday = obj.BirthDate;

                IdentityResult result = _userManager.CreateAsync(user, obj.Password).Result;

                if (result.Succeeded)
                {
                    if (!_roleManager.RoleExistsAsync("Admin").Result)
                    {
                        Role role = new Role();
                        role.Name = "Admin";
                        role.Description = "Administer site";
                        IdentityResult roleResult = _roleManager.
                        CreateAsync(role).Result;
                        if (!roleResult.Succeeded)
                        {
                            ModelState.AddModelError("","Error while creating role!");
                            return View(obj);
                        }
                    }

                    _userManager.AddToRoleAsync(user,"Admin").Wait();
                    return RedirectToAction("Login", "Account");
                }
            }

            return View(obj);

        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel obj)
        {
            if (ModelState.IsValid)
            {
                var result = _loginManager.PasswordSignInAsync(obj.UserName, obj.Password, obj.RememberMe, false).Result;

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Invalid login!");
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LogOff()
        {
            _loginManager.SignOutAsync().Wait();
            return RedirectToAction("Login", "Account");
        }
    }
}
