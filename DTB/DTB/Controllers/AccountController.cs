using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DTB.Controllers
{
    public class AccountController : BaseController
    {
        [HttpGet]
        [AllowAnonymous]
        public IActionResult UserRegister()
        {
            //ViewData["Title"] = "User Register";
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult CompanyRegister()
        {
            //ViewData["Title"] = "Company Register";
            return View();
        }
    }
}