using System;
using System.Collections.Generic;
using System.Text;
using GameSales.Entities;
namespace GameSales.Abstrac
{
    interface IOrderService
    {
        void SalesGame(Gamer gamer, Game game ,Campaign campaign);
    }
}
