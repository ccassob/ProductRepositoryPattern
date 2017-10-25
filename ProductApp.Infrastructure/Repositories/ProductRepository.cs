using ProductApp.Core.Models;
using ProductApp.Core.Repositories;
using ProductApp.Infrastructure.Contexts;
using System.Collections.Generic;
using System.Linq;

namespace ProductApp.Infrastructure.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ProductContext context) : base(context)
        {

        }
    }
}