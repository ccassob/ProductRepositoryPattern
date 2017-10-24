using ProductApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductApp.Core.Repositories;
using ProductApp.Infrastructure.Contexts;
using ProductApp.Infrastructure.Repositories;

namespace ProductApp.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProductContext _context;
        public IProductRepository Products { get; private set; }


        public UnitOfWork(ProductContext context)
        {
            _context = context;
            Products = new ProductRepository(_context);
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
