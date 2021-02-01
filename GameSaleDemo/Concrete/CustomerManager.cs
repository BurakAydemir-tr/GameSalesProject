using GameSaleDemo.Abstract;
using GameSaleDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Concrete
{
    public class CustomerManager : EntityRepositoryBase<Customer>,ICustomerService
    {
        private ICustomerCheckService _customerCheckService;
        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public override void Add(Customer entity)
        {
            if (_customerCheckService.CheckIfRealPerson(entity))
            {
                base.Add(entity);
            }
            else
            {
                Console.WriteLine("Geçersiz Kullanıcı");
            }
        }
       
    }
}
