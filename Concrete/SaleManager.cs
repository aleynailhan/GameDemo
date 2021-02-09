using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class SaleManager : ISaleService
    {
        public void DiscountSend(Player player, Game game, Campaign campaign)
        {
            Console.WriteLine("A cupon was sent to the {0} {1} with a {2}% discount for the purchase of {3} game.", player.FirstName, player.LastName, campaign.Discount, game.Name);
        }

        public void Sale(Player player, Game game, Campaign campaign)
        {
            if (campaign.Discount==0)
            {
                Console.WriteLine("{0} {1} bought the {2} game for {3]tl.",player.FirstName,player.LastName,game.Name,game.Price);
            }
            else
            {
                var price = game.Price;
                var discountRate = campaign.Discount;
                var payment_ = price - (price * discountRate) / 100;
                Console.WriteLine("{0} {1} bought the {2} game for {3}tl.",player.FirstName,player.LastName,game.Name,game.payment_);
            }
        }
    }
}
