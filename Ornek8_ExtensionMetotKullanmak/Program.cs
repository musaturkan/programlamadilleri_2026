using DataModel;

namespace Ornek8_ExtensionMetotKullanmak;

public class Program
{
    private static void Main(string[] args)
    {
        ///Extension Motot - Genişletme Metodu
        ///Mevcut bir sınıfa yeni bir özellik eklemek istediğimizde kullanılır.
        ///Sınıfın kodunu değiştirmeden yeni bir metot eklememizi sağlar.
        ///string, int gibi hazır sınıflara da yeni metotlar ekleyebiliriz.
        ///Kendi özel sınıflarımıza da yeni metotlar ekleyebiliriz.
        ///Özellikle harici sınıflara yeni metotlar eklemek istediğimizde çok kullanışlıdır.
        ///
        string isim = "ahmet";
        isim.Yazdir();
        isim.IlkHarfiBuyut().Yazdir();
        int sayi = 5;
        int kare = sayi.KareAl();
        kare.Yazdir();
        //Console.WriteLine(isim.IlkHarfiBuyut());
        ///string sınıfına yeni metotlar ekyebiliriz.
        ///Extinsion metot yazma kuralları:
        ///1- Static bir sınıf içinde yazılmalıdır.
        ///2- Static bir metot olmalıdır.
        ///3- İlk parametre this anahtar kelimesi ile belirtilmelidir.
        ///this anahtar kelimesi ile belirtilen parametre, genişletilen sınıfın bir örneğidir.
        ///extension metot yeni parametreler alabilir, ancak ilk parametre genişletilen sınıfın bir örneği olmalıdır.
        double sayi2 = 3.14;
        //sayi2.Yazdir();
        DataModel.Kullanici kullanici = new DataModel.Kullanici { Id = 1, Ad = "Ahmet", Soyad = "Yılmaz" };
        kullanici.Yazdir();
        List<string> isimler = new List<string> { "Ahmet", "Mehmet", "Ayşe" };

        isimler.Yazdir();
        List<int> sayilar = new List<int> { 1, 2, 3, 4, 5 };
        sayilar.Yazdir();
        List<Kullanici> kullanicilar = new List<Kullanici>
        {
            new Kullanici { Id = 1, Ad = "Ahmet", Soyad = "Yılmaz" },
            new Kullanici { Id = 2, Ad = "Mehmet", Soyad = "Demir" },
        };
        kullanicilar.Yazdir();

        kullanici.ToDTO();
      
        
        KullaniciDTO kullaniciDTO = kullanici.ToDTO();
        kullaniciDTO.ToEntity();

        ///Extension metot kullanmanın avantajları:
        ///1- Mevcut sınıflara yeni metotlar ekleyebiliriz.
        ///2- Sınıfın kodunu değiştirmeden yeni metotlar ekleyebiliriz.
        ///3- Kodun okunabilirliğini artırır.
        ///4- Tekrar kullanılabilirliği artırır.
        ///5- Extension metolar var olan metodu ezmez yeni metot ekler, Yani override yapmazlar.
        ///6- Extension metotlar, var olan sınıfın bir örneği üzerinden çağrılırlar, yani nesne yönelimli programlamaya uygun bir şekilde kullanılırlar.
        ///7- Çok fazla extension metot yazmak, kodun karmaşıklaşmasına neden olabilir, bu yüzden dikkatli kullanılmalıdır.
    }
}

public class KullaniciDTO
{
    public int Id { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
}

public static class KullaniciExtensions
{
    public static void Yazdir(this Kullanici kullanici)
    {
        Console.WriteLine($"Id: {kullanici.Id}, Ad: {kullanici.Ad}, Soyad: {kullanici.Soyad}");
    }

    public static KullaniciDTO ToDTO(this Kullanici kullanici)
    {
        return new KullaniciDTO
        {
            Id = kullanici.Id,
            Ad = kullanici.Ad,
            Soyad = kullanici.Soyad
        };
    }

    public static Kullanici ToEntity(this KullaniciDTO kullaniciDTO)
    {
        return new Kullanici
        {
            Id = kullaniciDTO.Id,
            Ad = kullaniciDTO.Ad,
            Soyad = kullaniciDTO.Soyad
        };
    }
}
public static class GenelExtensions
{
    public static void Yazdir(this string metin)
    {
        Console.WriteLine(metin);
    }
    public static string IlkHarfiBuyut(this string str)
    {
        if (string.IsNullOrEmpty(str))
            return str;
        return char.ToUpper(str[0]) + str.Substring(1); ///ahmet -> Ahmet  a -->A + hmet --> Ahmet
    }

    public static int KareAl(this int sayi)
    {
        return sayi * sayi;
    }

    public static void Yazdir(this int sayi)
    {
        Console.WriteLine(sayi);
    }

    //public static void Yazdir<T>(this T nesne) 
    //{
    //    Console.WriteLine(nesne);
    //}

    public static void Yazdir<T>(this List<T> liste)
    {
        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }
    }

    public static decimal OndalikKismiAl(this decimal sayi)
    {
        return sayi - Math.Floor(sayi);
    }
}