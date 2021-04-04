using GameSales.Abstrac;
using GameSales.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSales.Concrete
{
    class CampaignManager: ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name +"Kampanya Ekleme Başarıyla Tamamlandı");
        }

       

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name +"Kampanya Silme Başarıyla Tamamlandı");
        }

      

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name +"Kampanya Güncelleme Başarıyla Tamamlandı");
        }

       
    }
}
