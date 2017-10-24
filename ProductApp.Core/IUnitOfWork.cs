using ProductApp.Core.Repositories;
using System;

namespace ProductApp.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        int Complete();
    }
}