using ProductApp.Core.Models;
using ProductApp.Core.Repositories;
using ProductApp.Infrastructure.Contexts;

namespace ProductApp.Infrastructure.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ProductContext context) : base(context)
        {
        }
    }
}