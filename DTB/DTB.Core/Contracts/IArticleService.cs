using DTB.ViewModels.Article;

namespace DTB.Core.Contracts
{
    public interface IArticleService
    {
        Task AddArticleAsync(AddArticleViewModel model);

        Task<List<GetAllArticlesViewModel>> GetAllAsync();

        Task<ArticleViewModel> GetAricleByIdAsync(string id);
    }
}
