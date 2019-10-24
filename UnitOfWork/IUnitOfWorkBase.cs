
using UnitOfWorkSample.Repository;
using System;

namespace UnitOfWorkSample.UnitOfWork
{
    public interface IUnitOfWorkBase: IDisposable
    {
        IOrderRepository Orders { get; }
        IProductRepository Products { get; }
        ICampaignRepository Campaigns { get; }
        void Commit();
    }
}
