using Altic_Shaw_Net6_Api.Models;

namespace Altic_Shaw_Net6_Api.Repositories
{
    public interface IProductRepository
    {
        public Task<List<ProductModel>> getAllProductAsync();
        public Task<ProductModel> getProductByIdAsync(int id);
        public Task<ProductModel> getProductByNameAsync(string name);
        public Task<int> insertProductAsync(int productId, ProductModel product);
        public Task updateProductAsync(int productId, ProductModel product);
        public Task<int> deleteProductAsync(int productId);
    }
}
