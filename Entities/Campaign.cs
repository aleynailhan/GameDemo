using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    public class Campaign:IEntitiy
    {
        public int CampaignId { get; set; }
        public string Name { get; set; }
        public double Discount { get; set; }
    }
}
