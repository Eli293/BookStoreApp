﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using BookStoreApp.Models;


namespace BookStoreApp.Controllers
{
    public class UserController : Controller
    {
        private UserManager<User> userManager;
        private RoleManager<IdentityRole> roleManager;

        public UserController(UserManager<User> userMngr,
            RoleManager<IdentityRole> roleMngr)
        {
            userManager = userMngr;
            roleManager = roleMngr;
        }
        public async Task<IActionResult> Index()
        {
            List<User> users = new List<User>();
            foreach (User user in userManager.Users.ToList())
            {
                user.RoleNames = await userManager.GetRolesAsync(user);
                users.Add(user);
            }
            UserViewModel model = new UserViewModel
            {
                Users = users,
                Roles = roleManager.Roles
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            User user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result =
                    await userManager.DeleteAsync(user);
                if (!result.Succeeded)
                { // if failed
                    string errorMessage = "";
                    foreach (IdentityError error in result.Errors)
                    {
                        errorMessage += error.Description + " | ";
                    }
                    TempData["message"] = errorMessage;
                }
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> AddToAdmin(string id)
        {
            IdentityRole adminRole =
                await roleManager.FindByNameAsync("Admin");
            if (adminRole == null)
            {
                TempData["message"] = "Admin role does not exist. "
                    + "Click 'Create Admin Role' button to create it.";
            }
            else
            {
                User user = await userManager.FindByIdAsync(id);
                await userManager.AddToRoleAsync(user, adminRole.Name);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> RemoveFromAdmin(string id)
        {
            User user = await userManager.FindByIdAsync(id);
            await userManager.RemoveFromRoleAsync(user, "Admin");
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteRole(string id)
        {
            IdentityRole role = await roleManager.FindByIdAsync(id);
            await roleManager.DeleteAsync(role);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> CreateAdminRole()
        {
            await roleManager.CreateAsync(new IdentityRole("Admin"));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ChangePassword()
        {
            var model = new ChangePasswordViewModel
            {
                Username = User.Identity.Name // automatically fill the username of the logged-in user
            };
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await userManager.FindByNameAsync(
                    model.Username);
                var result = await userManager.ChangePasswordAsync(user,
                    model.OldPassword, model.NewPassword);

                if (result.Succeeded)
                {
                    TempData["SuccessMessagePassword"] = "Password changed successfully";
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new RegisterViewModel();
            return View(model);
        }



    }
}
