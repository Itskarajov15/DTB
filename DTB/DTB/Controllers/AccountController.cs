using Microsoft.AspNetCore.Mvc;

namespace DTB.Controllers
{
    public class AccountController : BaseController
    {
        [HttpGet]
        public IActionResult UserRegister()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CompanyRegister()
        {
            return View();
        }
    }
}