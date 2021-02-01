using GameSaleDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
