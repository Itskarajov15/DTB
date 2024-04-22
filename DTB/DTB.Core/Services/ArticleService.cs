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

        public async Task AddArticleAsync(AddArticleViewModel model)
        {
            var newArticle = new Article()
            {
                Id = Guid.NewGuid().ToString(),
                Title = model.Title,
                Content = model.Content,
                AuthorId = model.AuthorId,
                ImageUrl = model.ImageUrl,
                DateOfCreation= DateTime.Now
            };

            await context.AddAsync(newArticle);

            await context.SaveChangesAsync();
        }
    }
}
