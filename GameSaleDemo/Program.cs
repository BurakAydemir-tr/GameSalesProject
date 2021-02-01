using GameSaleDemo.Concrete;
using GameSaleDemo.Entity;
using System;

namespace GameSaleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 1,
                Ad = "Burak",
                Soyad = "Aydemir",
                DogumYili = new DateTime(1986, 2, 25),
                TcNo = "1234567890"
            };

            Campaign campaign1 = new Campaign()
            {
                Id = 1,
                Type = "ilk alış",
                Rate = 0.2,
                CampTime = 14
            };
            CustomerManager customerManager = new CustomerManager(new CustomerCheckManager());
            customerManager.Add(customer1);

            CampaingManager campaingManager = new CampaingManager();
            campaingManager.Add(campaign1);

            GameSalesManager gameSalesManager = new GameSalesManager();
            gameSalesManager.Sales(customer1, campaign1);
            Console.ReadLine();
            
        }
    }
}
