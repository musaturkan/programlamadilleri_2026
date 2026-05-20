using Ornek12_3_Ornekler.DTO;

namespace Ornek12_3_Ornekler;

internal class Program
{
    private static void Main(string[] args)
    {
        ///Generic sınıflar, tür bağımsız olarak çalışabilen sınıflardır. 
        ///Bu sınıflar,
        ///tür parametreleri alarak farklı türlerde nesneler oluşturabilirler.
        ///
        MesajIslem mesajIslem = new MesajIslem();
        SmsGonder smsGonder = new SmsGonder();

        mesajIslem.MesajGonder<SmsGonder>(smsGonder);

        ///Örnek olarak dto entity dönüşümlerinde generic sınıflar kullanılabilir.
        KullaniciDto kullanici = new KullaniciDto();
        kullanici.Id = 2;
        kullanici.Ad = "Ahmet";
        kullanici.Soyad = "Yılmaz";
        kullanici.KayitTarihi = DateTime.Now;
        DtoEntityDonusum donusum = new DtoEntityDonusum();
        var entity = donusum.DtoEntityYap<KullaniciDto, Entity.Kullanici>(kullanici);

        //Entity.Kullanici kullaniciEntity = new Entity.Kullanici();
        //kullaniciEntity.Id= kullanici.Id;
        //kullaniciEntity.Ad = kullanici.Ad;  
        //kullaniciEntity.Soyad = kullanici.Soyad;
        //kullaniciEntity.KayitTarihi = kullanici.KayitTarihi;



    }
}