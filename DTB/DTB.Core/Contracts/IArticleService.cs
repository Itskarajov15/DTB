using DTB.Models.Article;
using DTB.ViewModels.Article;

namespace DTB.Core.Contracts
{
    public interface IArticleService
    {
        Task<string> AddArticleAsync(AddArticleViewModel model, string id);

        Task<List<GetAllArticlesViewModel>> GetAllAsync();
    }
}
