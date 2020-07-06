using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    [Authorize(Roles ="Admin")]
    public class UserController : Controller 
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public UserController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }
        public IActionResult Index()
        {
            var users = userManager.Users;
            if(users!=null)
            {
                var model = new List<UserViewModel>();
                 model = users.Select(u => new UserViewModel()
                {
                    User = u.UserName,
                    Id = u.Id,
                    Email = u.Email
                }).ToList();
                foreach(var user in model)
                {
                    user.RolesName = GetRoleName(user.Id);
                }
                return View(model);
            }
            return View();
        }
        public string GetRoleName(string userId)
        {
            var user = Task.Run(async () => await userManager.FindByIdAsync(userId)).Result;
            var roles = Task.Run(async () => await userManager.GetRolesAsync(user)).Result;
            return roles != null ? string.Join(",", roles) : string.Empty;
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Roles = roleManager.Roles;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateAsync(UserCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser()
                {
                    UserName = model.User,
                    
                
                };
                var result = await userManager.CreateAsync(user, model.PassWord);
                if (result.Succeeded)
                {
                    if(!string.IsNullOrEmpty(model.RoleId))
                    {
                        var role = await roleManager.FindByIdAsync(model.RoleId);
                        var addRoleResult = await userManager.AddToRoleAsync(user, role.Name);
                        if(addRoleResult.Succeeded)
                            return RedirectToAction("Index", "User");
                        foreach (var error in addRoleResult.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                    }                      
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            if(user!=null)
            {
                var model = new EditUserViewModel()
                {
                    userId = user.Id,
                    phoneNumber = user.PhoneNumber,
                    Gender = user.Gender,
                    City = user.City,
                    Email = user.Email
                };
                var rolesName = await userManager.GetRolesAsync(user);
                if (rolesName != null && rolesName.Any())
                {
                    var role = await roleManager.FindByNameAsync(rolesName.FirstOrDefault());
                    model.RoleId = role.Id;
                }
                ViewBag.Roles = roleManager.Roles;
                return View(model);
            }
            ViewBag.Roles = roleManager.Roles;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(EditUserViewModel model)
        {
            if(ModelState.IsValid)
            {
                var user = await userManager.FindByIdAsync(model.userId);
                if(user!=null)
                {
                    user.Id = model.userId;
                    user.PhoneNumber = model.phoneNumber;
                    user.Gender = model.Gender;
                    user.City = model.City;
                    user.Email = model.Email;
                    var result = await userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        var rolesName = await userManager.GetRolesAsync(user);
                        var delRole = await userManager.RemoveFromRolesAsync(user, rolesName);
                        if(!string.IsNullOrEmpty(model.RoleId))
                        {
                            var role = await roleManager.FindByIdAsync(model.RoleId);
                            var addRoleResult = await userManager.AddToRoleAsync(user, role.Name);
                            if (addRoleResult.Succeeded)
                                return RedirectToAction("Index", "User");
                            foreach (var error in addRoleResult.Errors)
                            {
                                ModelState.AddModelError("", error.Description);
                            }
                        }    
                        return RedirectToAction("index", "user");
                    }    
                     
                    foreach(var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

                }
            }
            return View();  
        }
        public async Task<IActionResult> Delete(string id)

        {
            var user = await userManager.FindByIdAsync(id);
            if(user!=null)
            {
                var result = await userManager.DeleteAsync(user);
                if(result.Succeeded)
                {
                    return RedirectToAction("index", "user");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View();
        }
    }
}
