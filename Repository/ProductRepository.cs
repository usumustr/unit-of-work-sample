
using UnitOfWorkSample.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace UnitOfWorkSample.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly DbSet<Product> _productEntities;
        private readonly PlatformContext _context;

        public ProductRepository(DbContext context):base(context)
        {
            _productEntities = context.Set<Product>();
            _context = context as PlatformContext;
        }

        public Product GetProductByProductCode(string productCode)
        {
            return _productEntities.Where(pe => pe.ProductCode == productCode).Single();
        }
    }
}
