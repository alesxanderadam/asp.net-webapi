using Altic_Shaw_Net6_Api.Entities;
using Altic_Shaw_Net6_Api.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Altic_Shaw_Net6_Api.Repositories.Categories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IMapper _mapper;
        private readonly AlaticShawContext _shawContex;

        public CategoryRepository(AlaticShawContext shawContext , IMapper mapper)
        {
            _mapper = mapper;
            _shawContex = shawContext;

        }
        public async Task<int> DeleteCategoryAsync(int categoryId)
        {
           var deleteCategory = _shawContex.Categories!.SingleOrDefault(c => c.Id == categoryId);
            if(deleteCategory != null)
            {
                _shawContex.Categories.Remove(deleteCategory);
                await _shawContex.SaveChangesAsync();
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public async Task<List<CategoryModel>> getAllCategoriesAsync()
        {
            var category = await _shawContex.Categories!.ToListAsync();
            return _mapper.Map<List<CategoryModel>>(category);
        }

        public async Task<CategoryModel> getCategoryAsync(int categoryId)
        {
            var category = await _shawContex.Categories!.FindAsync(categoryId);
            return _mapper.Map<CategoryModel>(category);
        }

        public async Task<int> insertCategoryAsync(CategoryModel category)
        {
            try
            {
                var newCategory = _mapper.Map<Category>(category);
                _shawContex.Categories.Add(newCategory);
                await _shawContex.SaveChangesAsync();
                return newCategory.Id;
            }
            catch(Exception err)
            {
                return -1;
            }
        }

        public async Task<int> updateCategoryAsync(int categoryId, CategoryModel category)
        {
            if(categoryId == category.Id)
            {
                var updateCategory = _mapper.Map<Category>(category);
                _shawContex.Categories!.Update(updateCategory);
                await _shawContex.SaveChangesAsync();
                return 1;
            }
            else
            {
                return -1;
            }
           
        }
    
    }
}
