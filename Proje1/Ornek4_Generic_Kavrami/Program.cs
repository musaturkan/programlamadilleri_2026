using Ornek_4_Library_Generic_Kavrami;
using Ornek_4_Library_Generic_Kavrami.GenericDataModel;

namespace Ornek_4_Library_Generic_Kavrami;
internal class Program
{
    private static void Main(string[] args)
    {
        int sayi1 = 10; //Stack'te saklanır
        int sayi2 = 25; //sayi1'in değeri sayi2'ye kopyalanır
        int toplam = 0;
        double toplam2=0.0;

        List<int> sayilar = new List<int>(); //Generic List sınıfı kullanarak int türünde bir liste oluşturduk
        List<string> metinler = new List<string>(); //Generic List sınıfı kullanarak string türünde bir liste oluşturduk
        List<Kullanici> kullanicilar = new List<Kullanici>(); //Generic List sınıfı kullanarak Kullanici türünde bir liste oluşturduk

        ///Anahtar ve değer çiftleriyle çalışmak için Dictionary sınıfını kullanabiliriz
        Dictionary<int, string> kullaniciSozluk = new Dictionary<int, string>();
        kullaniciSozluk.Add(1, "Ahmet Yılmaz");
        kullaniciSozluk.Add(2, "Ayşe Kara");
        kullaniciSozluk.Add(3, "Mehmet Demir");
        kullaniciSozluk.Add(4, "Fatma Çelik");

        Dictionary<string, int> urunFiyatlari = new Dictionary<string, int>();
        urunFiyatlari.Add("Laptop", 5000);
        urunFiyatlari.Add("Telefon", 3000);
        urunFiyatlari.Add("Tablet", 2000);
        var fiyat = urunFiyatlari["Laptop"];

        Dictionary<string, Urun> urunler22 = new Dictionary<string, Urun>();
        urunler22.Add("Laptop", new Urun { Id = 1, Ad = "Laptop", Fiyat = 5000 });
        urunler22.Add("Telefon", new Urun { Id = 2, Ad = "Telefon", Fiyat = 3000 });
        var urun33 = urunler22["Laptop"];


        string kullaniciAdi = kullaniciSozluk[2];
        Console.WriteLine(kullaniciSozluk[2]);


        Matematik matematik = new Matematik();
        toplam = matematik.Topla<int>(52, sayi2);

        var sonuc = matematik.Topla<double>(34.6, 56.5);
        var sonuc2 = matematik.Topla(34, 56.5); //C# 12 ile gelen özellik sayesinde türü belirtmeye gerek kalmaz
        var sonuc3 = matematik.Topla<string>("Merhaba ", "Dünya");

       ///DataService generic sınfını kullanmak
        //DataService<int> dataService = new DataService<int>();
        //dataService.Add(10);
        //dataService.Add(toplam);
        //dataService.Add(sayi1);
        //dataService.Add(sayi2);

        //var sayilar = dataService.Listele();

        //DataService<string> dataService2 = new DataService<string>();
        //dataService2.Add("Merhaba");
        //dataService2.Add("Dünya");
        //var metinler = dataService2.Listele();

        DataService<Kullanici> dataService3 = new DataService<Kullanici>();
        dataService3.Add(new Kullanici { Id = 1, Ad = "Ahmet", Soyad = "Yılmaz" });
        dataService3.Add(new Kullanici { Id = 2, Ad = "Ayşe", Soyad = "Kara" });
        dataService3.Add(new Kullanici { Id = 3, Ad = "Mehmet", Soyad = "Demir" });
        var kullanicilar2 = dataService3.Listele();

        DataService<Urun> dataService4 = new DataService<Urun>();
        dataService4.Add(new Urun { Id = 1, Ad = "Laptop", Fiyat = 5000 });
        dataService4.Add(new Urun { Id = 2, Ad = "Telefon", Fiyat = 3000 });
        dataService4.Add(new Urun { Id = 3, Ad = "Tablet", Fiyat = 2000 });
        var urunler = dataService4.Listele();


        ///Entity ekleme işlemleri için generic olarak tanımladığımız sınıf kullanılabilir.
        ///Bu sadece tüm entity'ler için ortak bir sınıf olabilir. Örneğin, Repository pattern'inde bu tür bir yapı sıklıkla kullanılır.
        
        
        DataModelService<DataModel.Kullanici> dmServis = new DataModelService<DataModel.Kullanici>();
        DataModel.Kullanici yeniKullanici = new DataModel.Kullanici { Id = 1, Ad = "Ahmet", Soyad = "Yılmaz", Email = "" };

        dmServis.AddEntity(yeniKullanici);

        DataModelService<DataModel.Urun> dmServis2 = new DataModelService<DataModel.Urun>();
        DataModel.Urun yeniUrun = new DataModel.Urun { Id = 1, Ad = "Laptop", Fiyat = 5000 };
        dmServis2.AddEntity(yeniUrun);



        List<object> veri = new List<object>();
        veri.Add(50);
        veri.Add("Merhaba");
        veri.Add(yeniKullanici);
        veri.Add(yeniUrun);
        veri.Add(new Kullanici { Id = 2, Ad = "Ayşe", Soyad = "Kara" });
    }
}