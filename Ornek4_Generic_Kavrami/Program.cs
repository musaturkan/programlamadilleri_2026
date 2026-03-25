using Ornek_4_Library_Generic_Kavrami;

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
        var kullanicilar = dataService3.Listele();

        DataService<Urun> dataService4 = new DataService<Urun>();
        dataService4.Add(new Urun { Id = 1, Ad = "Laptop", Fiyat = 5000 });
        dataService4.Add(new Urun { Id = 2, Ad = "Telefon", Fiyat = 3000 });
        dataService4.Add(new Urun { Id = 3, Ad = "Tablet", Fiyat = 2000 });
        var urunler = dataService4.Listele();

    }
}