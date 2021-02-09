using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name+ "is added");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name+ "is deleted");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name+ "is updated");

        }
    }


}
