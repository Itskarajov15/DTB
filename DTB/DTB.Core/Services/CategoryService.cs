using DTB.Core.Contracts;
using DTB.Core.Models.Categories;
using DTB.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DTB.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _context;

        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<CategoryViewModel>> GetAllCategoriesAsync()
        {
            return await _context
                .Categories
                .Select(c => new CategoryViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    PictureUrl = c.PictureUrl,
                    DateOfCreation = c.DateOfCreation
                })
                .OrderBy(c => c.DateOfCreation)
                .ToListAsync();
        }
    }
}