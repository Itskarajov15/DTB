using DTB.Core.Contracts;
using DTB.Core.Models.Categories;
using DTB.Infrastructure.Data.Entities;
using DTB.ViewModels.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DTB.Controllers
{
    public class AccountController : BaseController
    {
        private UserManager<BaseUser> userManager;
        private SignInManager<BaseUser> signInManager;
        private ICategoryService categoryService;

        public AccountController(
            UserManager<BaseUser> userManager,
            SignInManager<BaseUser> signInManager,
            ICategoryService categoryService)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.categoryService = categoryService;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult UserRegister()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "Home");
            }

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
        public async Task<IActionResult> CompanyRegister()
        {
            var registerViewModel = new CompanyRegisterViewModel();
            registerViewModel.Categories = await this.categoryService.GetAllCategoriesAsync();

            return View(registerViewModel);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CompanyRegister(CompanyRegisterViewModel reqModel)
        {
            if (!ModelState.IsValid)
            {
                return View(ModelState);
            }

            var company = new Company
            {
                UserName = reqModel.Email,
                NormalizedUserName = reqModel.Email.ToUpper(),
                NormalizedEmail = reqModel.Email.ToUpper(),
                Name = reqModel.Name,
                Address = reqModel.Address,
                CategoryId = reqModel.CategoryId,
                Email = reqModel.Email
            };

            var result = await userManager.CreateAsync(company, reqModel.Password);

            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(company, "Company");

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
        public IActionResult Login()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(ModelState);
            }

            var user = await userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                model.Errors.Add("Invalid login credentials");

                return View(model);
            }

            var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);

            if (!result.Succeeded)
            {
                model.Errors.Add("Invalid login credentials");

                return View(model);
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            if (!User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "Home");
            }

            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}