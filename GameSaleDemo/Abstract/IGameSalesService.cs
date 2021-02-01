using GameSaleDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Abstract
{
    public interface IGameSalesService
    {
        void Sales(Customer customer, Campaign campaign);
    }
}
