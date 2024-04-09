using DTB.Core.Contracts;
using DTB.Infrastructure.Data;
using DTB.Infrastructure.Data.Entities;
using DTB.ViewModels.Article;
using Microsoft.EntityFrameworkCore;

namespace DTB.Core.Services
{
    public class ArticleService : IArticleService
    {
        private readonly ApplicationDbContext context;

        public ArticleService(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<string> AddArticleAsync(AddArticleViewModel model, string id)
        {
            Article article = new Article()
            {

            };

            await this.context.Articles.AddAsync(article);
            await this.context.SaveChangesAsync();

            return article.Id;
        }

        public async Task<ArticleViewModel> GetAricleByIdAsync(string id)
        {
            return await context
                .Articles
                .Where(a => a.Id == id)
                .Select(a => new ArticleViewModel
                {
                    Id = a.Id,
                    Title = a.Title,
                    Content = a.Content,
                    AuthorId = a.AuthorId,
                    AuthorName = $"{a.Author.FirstName} {a.Author.LastName}",
                    DateOfCreation = a.DateOfCreation.ToString("dd/mm/yyyy"),
                    ImageUrl = a.ImageUrl,
                }).FirstOrDefaultAsync();
        }

        public async Task<List<GetAllArticlesViewModel>> GetAllAsync()
        {
            return await context
                .Articles
                .Include(a => a.Author)
                .Select(a => new GetAllArticlesViewModel
                {
                    Id = a.Id,
                    AuthorId = a.AuthorId,
                    AuthorName = $"{a.Author.FirstName} {a.Author.LastName}",
                    DateOfCreation = a.DateOfCreation.ToString("dd/mm/yyyy"),
                    ImageUrl = a.ImageUrl,
                    Title = a.Title
                })
                .ToListAsync();
        }
    }
}
