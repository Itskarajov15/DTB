using DTB.Models.Article;

namespace DTB.Core.Contracts
{
    public interface IArticleService
    {
        Task<string> AddArticleAsync(AddArticleViewModel model, string id);
    }
}
