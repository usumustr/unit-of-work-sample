using UnitOfWorkSample.Context;
using Microsoft.EntityFrameworkCore;
using System;

namespace UnitOfWorkSample.Repository
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(DbContext context):base(context)
        {

        }

        public Order GetLastOrderById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
