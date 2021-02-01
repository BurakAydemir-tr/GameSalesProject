using GameSaleDemo.Abstract;
using GameSaleDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Concrete
{
    public class GameSalesManager : IGameSalesService
    {
        public void Sales(Customer customer, Campaign campaign)
        {
            Console.WriteLine("Oyun "+customer.Ad+" "+customer.Soyad+" "+campaign.Rate+
                " Oranında indirimle satıldı" );
        }
    }
}
