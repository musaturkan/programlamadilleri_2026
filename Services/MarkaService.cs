using DataModel;
using Microsoft.Extensions.Options;
using Services.Fabrika;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class MarkaService : IMarkaService
    {
        MarketContext context = new MarketContext();
        public void MarkaEkle(Marka yeniMarka)
        {
            ///marka bilgisini veri tabanına ekleme adımı
                       
            context.Marka.Add(yeniMarka);
            context.SaveChanges();
        }

        public void MarkaGuncelle(Marka guncellenecekMarka)
        {
            context.Marka.Update(guncellenecekMarka);
        }

        public void MarkaSil(int id)
        {
           var silinecekMarka = context.Marka.Find(id);
            if (silinecekMarka != null)
            {
                context.Marka.Remove(silinecekMarka);
                context.SaveChanges();
            }
        }

        public void Yazdir(int id = 1)
        {
            var marka = context.Marka.FirstOrDefault(p => p.Id == id);
            var m = context.Marka.Find(id);
            if (marka != null)
            {
                Console.WriteLine($"Id: {marka.Id}, Ad: {marka.Ad}");
            }
        }
    }
}
