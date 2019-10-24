
using UnitOfWorkSample.Context;
using Microsoft.EntityFrameworkCore;
using System;

namespace UnitOfWorkSample.Repository
{
    public class CampaignRepository:Repository<Campaign>, ICampaignRepository
    {
        private readonly PlatformContext _context;

        public CampaignRepository(DbContext context):base(context)
        {
            _context = context as PlatformContext;
        }

        public Campaign GetActiveCampaignByName(string campaignName)
        {
            throw new NotImplementedException();
        }
    }
}
