using ProductApp.Core;
using ProductApp.Core.Repositories;
using ProductApp.Infrastructure.Contexts;
using ProductApp.Infrastructure.Repositories;
using System;

namespace ProductApp.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool disposed = false;
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

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}