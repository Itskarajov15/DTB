using DTB.Infrastructure.Data.Entities;
using DTB.ViewModels.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DTB.Controllers
{
    public class AccountController : BaseController
    {
        private UserManager<BaseUser> userManager;

        public AccountController(UserManager<BaseUser> userManager)
        {
            this.userManager = userManager;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult UserRegister()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> UserRegister(UserRegisterViewModel reqModel)
        {
            if (!ModelState.IsValid)
            {
                return View(ModelState);
            }

            var user = new User
            {
                UserName = reqModel.Email,
                NormalizedUserName = reqModel.Email.ToUpper(),
                NormalizedEmail = reqModel.Email.ToUpper(),
                FirstName = reqModel.FirstName,
                MiddleName = reqModel.MiddleName,
                LastName = reqModel.LastName,
                Email = reqModel.Email,
                DateOfBirth = reqModel.DateOfBirth,
                Status = reqModel.Status
            };

            var result = await userManager.CreateAsync(user, reqModel.Password);

            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, "User");

                return RedirectToAction(nameof(Login));
            }

            reqModel.Errors = result
                                .Errors
                                .Select(e => e.Description)
                                .ToList();

            return View(reqModel);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult CompanyRegister()
        {
            //ViewData["Title"] = "Company Register";
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            //ViewData["Title"] = "Company Register";
            return View();
        }
    }
}