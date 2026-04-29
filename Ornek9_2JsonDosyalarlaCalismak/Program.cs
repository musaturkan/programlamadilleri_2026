
using Ornek9_2JsonDosyalarlaCalismak.Models;
using System.Text.Json;

namespace Ornek9_2JsonDosyalarlaCalismak;
internal class Program
{
    ///JSON - JavaScript Object Notation
    ///İnsanlar tarafından kolay okunabilir,anlaşılabilir formatta veri alışverişi için kullanılan bir veri formatıdır.
    ///JSON, veri yapısını temsil etmek için anahtar-değer çiftlerini kullanır.
    ///API'ler, web uygulamaları ve diğer yazılım sistemleri arasında veri alışverişi için yaygın olarak kullanılır.
    ///Programlama ortamındaki nesneler jsona dönüştürülerek veri alışverişi yapılır.
    ///JSON, birçok programlama dilinde desteklenir ve genellikle veri serileştirme ve deseralizasyon işlemleri için kullanılır.
    ///Serialization: Serileştirme, nesneyi json stiring formatına dönüştürme işlemidir.
    ///Deserialization: Deseralizasyon, json string formatındaki veriyi nesneye dönüştürme işlemidir.
    ///.NET'te JSON işlemleri için System.Text.Json ve Newtonsoft.Json gibi popüler kütüphaneler bulunmaktadır.
    private static void Main(string[] args)
    {
        ///C# nesnesini jsona dönüştürme
        ///Örnek bir KullaniciDTO nesnesi oluşturalım
        //KullaniciDTO kullanici = new KullaniciDTO
        //{
        //    Id = 1,
        //    Ad = "Ahmet",
        //    Soyad = "Yılmaz",
        //    Sehir = "İstanbul",
        //    DogumYili = 1990
        //};
        ///KullaniciDTO nesnesini json string formatına dönüştürelim
        ///JsonDosyayaYaz(kullanici);
        ///
        //KullaniciDTO okunanVeri = JsonDosyadanOku();

        //JsonKullaniciListeEkle();

        string jsonVerisi = File.ReadAllText("kullaniciListesi.json", System.Text.Encoding.UTF8);
        string a = jsonVerisi ?? "json verisi boş";

        var liste = JsonKullaniciListeOku();
    }


    public static void JsonKullaniciListeEkle()
    {
        List<KullaniciDTO> kullaniciListesi = new List<KullaniciDTO>
        {
            new KullaniciDTO { Id = 1, Ad = "Ahmet", Soyad = "Yılmaz", Sehir = "İstanbul", DogumYili = 1990 },
            new KullaniciDTO { Id = 2, Ad = "Ayşe", Soyad = "Demir", Sehir = "Ankara", DogumYili = 1985 },
            new KullaniciDTO { Id = 3, Ad = "Mehmet", Soyad = "Kara", Sehir = "İzmir", DogumYili = 1995 }
        };

        JsonSerializerOptions jsonAyar = new JsonSerializerOptions
        {
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping, // Türkçe karakterlerin düzgün görünmesini sağlar
            WriteIndented = true // JSON çıktısını daha okunabilir hale getirmek için girintili yapar
        };
        string kullaniciListesiJsonVerisi = JsonSerializer.Serialize(kullaniciListesi, jsonAyar);
        File.WriteAllText("kullaniciListesi.json", kullaniciListesiJsonVerisi, System.Text.Encoding.UTF8);
    }

    public static List<KullaniciDTO> JsonKullaniciListeOku()
    {
        string jsonVerisi = File.ReadAllText("kullaniciListesi.json", System.Text.Encoding.UTF8);
        List<KullaniciDTO> kullaniciListesi = JsonSerializer.Deserialize<List<KullaniciDTO>>(jsonVerisi) ?? new List<KullaniciDTO>();
        
        return kullaniciListesi;
    }

    public static void JsonDosyayaYaz(Models.KullaniciDTO kullanici)
    {
        JsonSerializerOptions jsonAyar = new JsonSerializerOptions
        {
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping, // Türkçe karakterlerin düzgün görünmesini sağlar
            WriteIndented = true // JSON çıktısını daha okunabilir hale getirmek için girintili yapar
        };
        string kullaniciJsonVerisi = JsonSerializer.Serialize(kullanici, jsonAyar);
        File.WriteAllText("kullanici.json", kullaniciJsonVerisi, System.Text.Encoding.UTF8);
    }

    public static KullaniciDTO JsonDosyadanOku()
    {
        string jsonVerisi = File.ReadAllText("kullanici.json", System.Text.Encoding.UTF8);

        KullaniciDTO kullanici = JsonSerializer.Deserialize<KullaniciDTO>(jsonVerisi);
        
        return kullanici;
        //Console.WriteLine($"Id: {kullanici.Id}");
        //Console.WriteLine($"Ad: {kullanici.Ad}");
        //Console.WriteLine($"Soyad: {kullanici.Soyad}");
        //Console.WriteLine($"Sehir: {kullanici.Sehir}");
        //Console.WriteLine($"DogumYili: {kullanici.DogumYili}");
    }
}