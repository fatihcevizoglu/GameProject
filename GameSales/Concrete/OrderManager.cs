using GameSales.Abstrac;
using System;
using System.Collections.Generic;
using System.Text;
using GameSales.Entities;

namespace GameSales.Concrete
{
    class OrderManager : IOrderService
    {
        public void SalesGame(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("           Oyuncu   :  "+gamer.FirsName + " " +gamer.LastName);
            Console.WriteLine("Satın Alınıcak Oyun :  " + game.GameName);
            Console.WriteLine("       Oyun Fiyatı  :  "+ game.Price );
            Console.WriteLine();
            Console.WriteLine( campaign.Name + "  İndirim Oranı  % " + campaign.Rate );

            double price;

            price = (game.Price * campaign.Rate)/100;

            Console.WriteLine("İndirilmiş Satış Fiyatı :   " + price);
        }
    }
}
