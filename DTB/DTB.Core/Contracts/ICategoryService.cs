using DTB.Core.Models.Categories;

namespace DTB.Core.Contracts
{
    public interface ICategoryService
    {
        Task<List<CategoryViewModel>> GetAllCategoriesAsync();
    }
}