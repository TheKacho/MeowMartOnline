using MeowMartOnline.Api.Data;
using MeowMartOnline.Api.Entities;
using MeowMartOnline.Api.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace MeowMartOnline.Api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly MeowMartOnlineDbContext meowMartOnlineDbContext;
        public ProductRepository(MeowMartOnlineDbContext meowMartOnlineDbContext)
        {
            this.meowMartOnlineDbContext = meowMartOnlineDbContext;
        }
        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await this.meowMartOnlineDbContext.ProductCategories.ToListAsync();
            return categories;
        }

        public Task<ProductCategory> GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await this.meowMartOnlineDbContext.Products.ToListAsync();
            
            return products;

        }
    }
}
