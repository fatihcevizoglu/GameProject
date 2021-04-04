using GameSales.Abstrac;
using GameSales.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using ServiceReference1;


namespace GameSales.Adapters
{
    class MernisServiceAdapters : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(gamer.IdentityNumber, gamer.FirsName.ToUpper(), gamer.LastName.ToUpper(), gamer.BirthYear); 
        }
    }
}
