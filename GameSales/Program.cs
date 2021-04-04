using GameSales.Concrete;
using GameSales.Entities;
using System;

namespace GameSales
{
    class Program
    {
        static void Main(string[] args)
        {

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, FirsName = "Selim", LastName = "Taşkın", BirthYear = 1999, IdentityNumber = 12345678 });


            //Veri Tabanı Bilgileri
            
                gamerManager.Add( new Gamer{ 
               Id = 1,
               FirsName = "Mehmet",
               LastName = "Çetin",
               BirthYear = 1999,
               IdentityNumber = 2536812345,
        });

                Gamer gamer2 = new Gamer();
                gamer2.Id = 2;
                gamer2.FirsName = "Melisa";
                gamer2.LastName = "Güneş";
                gamer2.BirthYear = 1998;
                gamer2.IdentityNumber = 2536812347;

                Game game1 = new Game();
                game1.Id = 14;
                game1.GameName = "Strateji_012";
                game1.Price = 24.90;

                Game game2 = new Game();
                game2.Id = 25;
                game2.GameName = "Maceraya Başlangıç";
                game2.Price = 34.90;

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Add(game2);

                Campaign campaign1 = new Campaign();
                campaign1.Id = 3;
                campaign1.Name = "Yaz Kampanyası";
                campaign1.Rate = 25;

                Campaign campaign2 = new Campaign();
                campaign2.Id = 6;
                campaign2.Name = "Tatil İndirimleri";
                campaign2.Rate = 50;
            CampaignManager campaign = new CampaignManager();
            campaign.Add(campaign1);
            campaign.Add(campaign2);

            //
            Console.WriteLine("----------------------------------------------- ");


            OrderManager orderManager = new OrderManager();
            orderManager.SalesGame(gamer2,game1,campaign1);

        }
    }
}
