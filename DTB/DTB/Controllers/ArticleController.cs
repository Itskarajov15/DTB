using Microsoft.AspNetCore.Mvc;

namespace DTB.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}