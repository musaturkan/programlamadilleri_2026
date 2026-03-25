using DataModel;
using Services.Fabrika;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services;

public class UrunService : IUrunService
{
    private MarketContext context = new MarketContext();
    public void UrunEkle(DataModel.Urun yeniUrun)
    {
        ///ürün bilgisini veri tabanına ekleme adımı
        ///
        //MarketContext context = new MarketContext();
        context.Urun.Add(yeniUrun);
        context.SaveChanges();
    }

    public void UrunGuncelle(DataModel.Urun guncellenecekUrun)
    {
        ///ürün bilgisini veri tabanında güncelleme adımı
        ///
        //MarketContext context = new MarketContext();
        context.Urun.Update(guncellenecekUrun);
        context.SaveChanges();
    }
    public void UrunSil(int id)
    {
        ///ürün bilgisini veri tabanından silme adımı
        ///
       /// MarketContext context = new MarketContext();
        var silinecekUrun = context.Urun.Find(id);
        if (silinecekUrun != null)
        {
            context.Urun.Remove(silinecekUrun);
            context.SaveChanges();
        }

    }

    public void Yazdir(int id=1)
    {
      ///MarketContext context = new MarketContext();
        var urun = context.Urun.FirstOrDefault(p=>p.Id==id);
        var u = context.Urun.Find(id);

        if (urun != null)
        {
            Console.WriteLine($"Id: {urun.Id}, Ad: {urun.Ad}, Fiyat: {urun.Fiyat}");
        }
    }

    public void Yazdir(Urun urun)
    {
        if (urun != null)
        {
            Console.WriteLine($"Id: {urun.Id}, Ad: {urun.Ad}, Fiyat: {urun.Fiyat}");
        }
    }
}
