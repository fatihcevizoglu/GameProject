using System;
using System.Collections.Generic;
using System.Text;
using GameSales.Abstrac;
using GameSales.Entities;

namespace GameSales.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1999 && gamer.FirsName == "Selim" && gamer.LastName == "Taşkın" && gamer.IdentityNumber == 12345678)
            {
                return true;
            }
            else { return false; }

        }
    }
}
