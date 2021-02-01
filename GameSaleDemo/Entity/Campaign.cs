using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Entity
{
    public class Campaign:IEntity
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public double Rate { get; set; }
        public int CampTime { get; set; }
    }
}
