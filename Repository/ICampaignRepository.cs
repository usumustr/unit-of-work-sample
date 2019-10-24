
using UnitOfWorkSample.Context;

namespace UnitOfWorkSample.Repository
{
    public interface ICampaignRepository:IRepository<Campaign>
    {
        Campaign GetActiveCampaignByName(string campaignName);
    }
}
