using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DTB.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
    }
}