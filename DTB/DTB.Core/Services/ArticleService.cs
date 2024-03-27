using DTB.Core.Contracts;
using DTB.Infrastructure.Data;
using DTB.Infrastructure.Data.Entities;
using DTB.Models.Article;

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
    }
}
