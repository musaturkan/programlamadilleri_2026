using DataModel;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Merhaba EntityFrameworkCore");

        List<Urun> urunListesi = new List<Urun>();
        //EF ile veri tabanı sorgulamak için önce bir model nesnesi oluşturulur

        urunListesi = UrunListeGetir();
        UrunYazdir(urunListesi);      

        var markaListesi = MarkaListeGetir();
        MarkaYazdir(markaListesi);
        
    }

    static void UrunYazdir(List<Urun> urunListesi)
    {
        foreach (var urun in urunListesi)
        {
            Console.WriteLine($"{urun.Id}-{urun.Ad} - {urun.Fiyat} Marka:{urun.Marka?.Ad}");
        }
    }
    static void MarkaYazdir(List<Marka> markaListe)
    {
        foreach (var marka in markaListe)
        {
            int urunSayisi = 0;
            //if (marka.Urun!=null)
            //{
            //    urunSayisi = marka.Urun.Count;
            //}

            urunSayisi = marka.Urun == null ? 0 : marka.Urun.Count;

            Console.WriteLine($"Marka Adı:{marka.Ad} - Ürün Sayısı:{urunSayisi}");
        }
    }
    /// <summary>
    /// Tüm ürünlerin listesini marka bilgileriyle döndürür
    /// </summary>
    /// <returns>Dönen ürün listesinde her bir ürünün markası da bulunur</returns>
    static List<Urun> UrunListeGetir()
    {
        MarketContext dbModel = new MarketContext();
        var urunListesi = dbModel.Urun.Include("Marka").ToList();
        return urunListesi;
    }

    /// <summary>
    /// Tüm marka bilgilerini liste olarak döndürür
    /// </summary>
    /// <returns></returns>
    static List<Marka> MarkaListeGetir()
    {
        MarketContext dbModel = new MarketContext();
        var markaListesi = dbModel.Marka.ToList();
        return markaListesi;
    }
}