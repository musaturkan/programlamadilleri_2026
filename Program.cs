using DataModel;
using Microsoft.Extensions.DependencyInjection;
using Services;
using Services.Fabrika;

internal class Program
{
    static void Degistir(Urun u)
    {
        u.Ad = "Buzdolabı";
        u = new Urun { Id = 3, Ad = "Televizyon", Fiyat = 4000 };
        u.Ad = "Çamaşır Makinesi";
    }
    private static void Main(string[] args)
    {
        ///Dependency Injection (Bağımlılık Enjeksiyonu) Nedir?
        ///Servis sınıflarının ihtiyaç duyduğu bağımlılıkları dışarıdan sağlayarak, sınıflar arasındaki bağımlılıkları azaltmayı amaçlayan bir tasarım desenidir.
        ///Servis sınıflarını new ile yeni nesne olarak türetmek yerine
        ///sunum katmanında interface'ler kullanılır ve bu interface'lerin somut implementasyonları servis katmanında oluşturulur.
        ///interface içine yerleşecek nesne de servis katmanında oluşturulur
        
        var servisler = new ServiceCollection();                
        servisler.AddTransient<IUrunService, UrunService>();
        servisler.AddScoped<IMarkaService, MarkaService>();
        servisler.AddSingleton<IFabrika, ServiceFabrika>();       

        var serviceProvider = servisler.BuildServiceProvider();



        var fabrika = serviceProvider.GetService<IFabrika>();
        //var urunService = serviceProvider.GetService<IUrunService>();
        var urunService = fabrika.UrunServiceOlustur();
        urunService.Yazdir(3);
        var markaService = fabrika.MarkaServiceOlustur();
        markaService.MarkaEkle(new Marka { Id = 1, Ad = "Samsung" });

        /////Stack ve Heap Kavramları
        /////Value Type ve Reference Type Kavramları
        /////Garbage Collector (Çöp Toplama) Mekanizması
        /////
        //int sayi1 = 10; //Stack'te saklanır
        //int sayi2 = sayi1; //sayi1'in değeri sayi2'ye kopyalanır
        //sayi2 = 20; //sayi2'nin değeri değiştirilir, sayi1 etkilenmez
        //Console.WriteLine(sayi1);

        //Urun urun1; //Stack'te saklanır, ancak içindeki veriler Heap'te saklanır
        //urun1 = new Urun { Id = 1, Ad = "Laptop", Fiyat = 5000 }; //Heap'te saklanır
        ////Urun urun1 = new Urun { Id = 1, Ad = "Laptop", Fiyat = 5000 }; //Heap'te saklanır
        /////urun1.Ad = "Masaüstü Bilgisayar"; //urun1'in Ad özelliği değiştirilir

        //Urun urun2 = new Urun { Id = 2, Ad = "Telefon", Fiyat = 3000 }; //Heap'te saklanır

        /////urun2 = urun1; //urun1'in referansı urun2'ye atanır, her iki değişken de aynı nesneyi gösterir

        ////urun2.Ad= "Tablet"; //urun2'nin Ad özelliği değiştirilir, urun1 de etkilenir çünkü her iki değişken aynı nesneyi gösterir

        //Degistir(urun2);

        //Console.WriteLine(urun1.Ad); //Laptop
        //Console.WriteLine(urun2.Ad);


        ////////////Metot çağırma işlemi//////
        //Services.UrunService urunService = new Services.UrunService();
        //var urunService = Services.ServiceFabrika.UrunServiceOlustur();
        var urunServis = serviceProvider.GetService<IUrunService>();
        urunServis.Yazdir(5);

    }


   
}