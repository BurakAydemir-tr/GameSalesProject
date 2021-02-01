using GameSaleDemo.Abstract;
using GameSaleDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Concrete
{
    public class CampaingManager:EntityRepositoryBase<Campaign>,ICampaignService
    {
    }
}
