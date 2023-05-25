using Altic_Shaw_Net6_Api.Entities;
using Altic_Shaw_Net6_Api.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Altic_Shaw_Net6_Api.Repositories.Products
{
    public class ProductRepository : IProductRepository
    {
        private readonly AlaticShawContext _alaticShawContext;
        private readonly IMapper _mapper;

        public ProductRepository(AlaticShawContext alaticShawContext, IMapper mapper)
        {
            _alaticShawContext = alaticShawContext;
            _mapper = mapper;
        }

        public async Task<int> deleteProductAsync(int productId)
        {
            var deleteProduct = _alaticShawContext.Products!.SingleOrDefault(p => p.Id == productId);
            if (deleteProduct != null)
            {
                _alaticShawContext.Products.Remove(deleteProduct);
                await _alaticShawContext.SaveChangesAsync();
            }
            return productId;
        }

        public async Task<List<ProductModel>> getAllProductAsync()
        {
            var products = await _alaticShawContext.Products!.ToListAsync();
            return _mapper.Map<List<ProductModel>>(products);
        }

        public async Task<ProductModel> getProductByIdAsync(int id)
        {
            var products = await _alaticShawContext.Products!.FindAsync(id);
            return _mapper.Map<ProductModel>(products);
        }

        public Task<ProductModel> getProductByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<int> insertProductAsync(int productId, ProductModel product)
        {
            var newProduct = _mapper.Map<Product>(product);
            _alaticShawContext.Products!.Add(newProduct);
            await _alaticShawContext.SaveChangesAsync();
            return newProduct.Id;
        }

        public async Task updateProductAsync(int productId, ProductModel product)
        {
            if (productId == product.Id)
            {
                var updateProduct = _mapper.Map<Product>(product);
                _alaticShawContext.Products!.Update(updateProduct);
                await _alaticShawContext.SaveChangesAsync();
            }
        }
    }
}
