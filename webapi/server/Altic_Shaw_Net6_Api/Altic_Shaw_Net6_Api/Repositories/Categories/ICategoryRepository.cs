using Altic_Shaw_Net6_Api.Entities;
using Altic_Shaw_Net6_Api.Models;

namespace Altic_Shaw_Net6_Api.Repositories.Categories
{
    public interface ICategoryRepository
    {
        public Task<List<CategoryModel>> getAllCategoriesAsync();
        public Task<CategoryModel> getCategoryAsync(int categoryId);
        public Task<int> insertCategoryAsync(CategoryModel category);
        public Task<int> updateCategoryAsync(int categoryId, CategoryModel category);
        public Task<int> DeleteCategoryAsync(int categoryId);
    }
}
