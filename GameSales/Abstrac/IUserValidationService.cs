using System;
using System.Collections.Generic;
using System.Text;
using GameSales.Entities;
namespace GameSales.Abstrac
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
