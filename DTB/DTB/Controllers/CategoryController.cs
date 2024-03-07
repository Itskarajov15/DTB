using DTB.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace DTB.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var categories = await _categoryService.GetAllCategoriesAsync();

            return PartialView("_GetAllCategories", categories);
        }
    }
}