using GameSales.Abstrac;
using System;
using System.Collections.Generic;
using System.Text;
using GameSales.Entities;

namespace GameSales.Concrete
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine(gamer.FirsName +"  "+ gamer.LastName +"   Kayıt Tamamlandı");
            }
            else
            {
                Console.WriteLine(gamer.FirsName +"   "+ gamer.LastName +"  Doğrulama Başarısız");
            }


        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Silme İşlemi Tamamlandı");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Güncelleme Tamamlandı");
        }

        public bool Validate(Gamer gamer)
        {
            throw new NotImplementedException();
        }
    }
}
