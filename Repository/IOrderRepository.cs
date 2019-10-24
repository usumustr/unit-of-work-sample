using UnitOfWorkSample.Context;

namespace UnitOfWorkSample.Repository
{
    public interface IOrderRepository:IRepository<Order>
    {
        Order GetLastOrderById(long id);
    }
}
