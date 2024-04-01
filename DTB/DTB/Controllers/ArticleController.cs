using DTB.Core.Contracts;
using DTB.Models.Article;
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
            //if (this.User.GetId() != model.Id)
            //{
            //    this.TempData[ErrorMessage] = "You must be registered in order to add articles!";
            //    return this.RedirectToAction("Index", "Home");
            //}

            string date = WebUtility.HtmlEncode(model.DateOfCreation.ToString());

            DateTime dateOfCreation = DateTime.Parse(date);

            if (dateOfCreation >= DateTime.UtcNow)
            {
                ModelState.AddModelError(nameof(model.DateOfCreation), "Selected date of creation is not valid!");
            }

            if (!ModelState.IsValid)
            {
                //TempData[ErrorMessage] = "You cannot add a new article!";
                return View(model);
            }

            try
            {
                //await this.articleService.AddArticleAsync(model, this.User.GetId()!);
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, "Unexpected error occurred while trying to add your new article! Please try again later or contact administrator.");

                return this.View(model);
            }

            //TempData[SuccessMessage] = "You have added a new article successfully!";
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var articles = await articleService.GetAllAsync();

            return View(articles);
        }
    }
}