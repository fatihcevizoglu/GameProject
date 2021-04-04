using GameSales.Abstrac;
using GameSales.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSales.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine( game.GameName +"  Oyun Ekleme Başarıyla Tamamlandı");
        }


        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + "  Oyun Silme Başarıyla Tamamlandı");
        }

        

        public void Update(Game game)
        {
            Console.WriteLine( game.GameName +"  Oyun Güncelleme Başarıyla Tamamlandı ");
        }

    }
}
