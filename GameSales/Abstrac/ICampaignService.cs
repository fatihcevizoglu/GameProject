using System;
using System.Collections.Generic;
using System.Text;
using GameSales.Entities;

namespace GameSales.Abstrac
{
    interface ICampaignService
    {
        void Add(Campaign campaign);

        void Update(Campaign campaign);

        void Delete(Campaign campaign);
    }
}
