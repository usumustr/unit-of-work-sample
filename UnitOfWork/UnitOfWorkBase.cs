using UnitOfWorkSample.Repository;
using Microsoft.EntityFrameworkCore;
using System;

namespace UnitOfWorkSample.UnitOfWork
{
    public class UnitOfWorkBase : IUnitOfWorkBase
    {
        private readonly DbContext _context;
        private readonly ICampaignRepository _campaigns;
        private readonly IOrderRepository _orders;
        private readonly IProductRepository _products;

        public UnitOfWorkBase(DbContext context)
        {
            _context = context;
        }

        public IOrderRepository Orders
        {
            get
            {
                return _orders ?? new OrderRepository(_context);
            }
        }

        public IProductRepository Products
        {
            get
            {
                return _products ?? new ProductRepository(_context);
            }
        }

        public ICampaignRepository Campaigns
        {
            get
            {
                return _campaigns ?? new CampaignRepository(_context);
            }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

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
