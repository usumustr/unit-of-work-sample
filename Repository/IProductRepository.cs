using UnitOfWorkSample.Context;

namespace UnitOfWorkSample.Repository
{
    public interface IProductRepository:IRepository<Product>
    {
        Product GetProductByProductCode(string productCode);
    }
}
