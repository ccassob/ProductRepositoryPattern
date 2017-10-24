using ProductApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Infrastructure.Contexts
{
    public class ProductContext : DbContext
    {
        public ProductContext()
            : base()
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
