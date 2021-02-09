using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface ISaleService
    {
        void DiscountSend(Player player, Game game, Campaign campaign);
        void Sale(Player player, Game game, Campaign campaign);
    }
}
