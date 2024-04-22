using DTB.Core.Contracts;
using DTB.ViewModels.Article;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DTB.Controllers
{
    public class ArticleController : BaseController
    {
        private readonly IArticleService articleService;

        public ArticleController(IArticleService articleService)
        {
            this.articleService = articleService;
        }

        [HttpGet]
        public IActionResult Add()
        {
            AddArticleViewModel viewModel = new AddArticleViewModel();

            //viewModel.Id = GetUserId();

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddArticleViewModel model)
        {
            model.AuthorId = User.Identity.Name;
            await articleService.AddArticleAsync(model);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var articles = await articleService.GetAllAsync();

            return View(articles);
        }

        [HttpGet]
        public async Task<IActionResult> Article(string id)
        {
            var article = await articleService.GetAricleByIdAsync(id);

            return View(article);
        }
    }
}