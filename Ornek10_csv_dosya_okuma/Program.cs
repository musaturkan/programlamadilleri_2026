using System.Data;

namespace Ornek10_csv_dosya_okuma;
internal class Program
{
    private static void Main(string[] args)
    {
        ///CSV (Comma-Separated Values) dosyaları, verileri virgülle ayrılmış bir formatta saklayan düz metin dosyalarıdır.
        ///Her satır bir veri kaydını temsil eder ve her sütun bir veri alanını temsil eder.
        ///CSV dosyaları genellikle veri alışverişi ve veri depolama için kullanılır.   
        ///CSV dosyaları excel gibi programlarda açılabilir ve düzenlenebilir.
        ///Tablo şeklinde veri saklamak için kullanılır.
        ///Ad, Soyad, DogumTarihi, Sehir
        ///Musa, Topal, 01.01.1990, İstanbul
        ///Ayşe, Demir, 15.05.1985, Ankara
        ///Jale, Yılmaz, 20.10.1995, İzmir
        ///İlk satırda sütun başlıkları bulunur ve sonraki satırlarda veri kayıtları yer alır.
        using (StreamWriter sw = new StreamWriter("kullanici.csv", false, System.Text.Encoding.UTF8))
        {
            sw.WriteLine("Ad,Soyad,Sehir");
            sw.WriteLine("Musa,Topal,İstanbul");
            sw.WriteLine("Ayşe,Demir,Ankara");
            sw.WriteLine("Jale,Yılmaz,İzmir");
        }

        CSVDosyasiniKutupaneIleOkuma();

    }

    public static void CSVDosyaYaz()
    {
        using (StreamWriter sw = new StreamWriter("kullanici.csv", false, System.Text.Encoding.UTF8))
        {
            ///KullaniciDTO nesnelerini csv dosyasına yazalım
            List<KullaniciDTO> kullanicilar = new List<KullaniciDTO>
        {
            new KullaniciDTO { Ad = "Musa", Soyad = "Topal", Sehir = "İstanbul" },
            new KullaniciDTO { Ad = "Ayşe", Soyad = "Demir",  Sehir = "Ankara" },
            new KullaniciDTO { Ad = "Jale", Soyad = "Yılmaz", Sehir = "İzmir" }
        };
            sw.WriteLine("Ad,Soyad,DogumTarihi,Sehir");
            foreach (var kullanici in kullanicilar)
            {
                //sw.WriteLine($"{kullanici.Ad},{kullanici.Soyad},{kullanici.DogumTarihi:dd.MM.yyyy},{kullanici.Sehir}");
            }
        }
    }

    public static void CSVDosyaOku()
    {
        using (StreamReader sr = new StreamReader("kullanici.csv", System.Text.Encoding.UTF8))
        {
            string? satir;
            while ((satir = sr.ReadLine()) != null)
            {
                string[] sutunlar = satir.Split(',');
                Console.WriteLine(satir);
            }
        }
    }

    public List<KullaniciDTO> CSVDosyasindanKullaniciDTOOku()
    {
        List<KullaniciDTO> kullanicilar = new List<KullaniciDTO>();
        using (StreamReader sr = new StreamReader("kullanici.csv", System.Text.Encoding.UTF8))
        {
            string? satir;
            bool ilkSatir = true; // İlk satırı atlamak için
            while ((satir = sr.ReadLine()) != null)
            {
                if (ilkSatir)
                {
                    ilkSatir = false; // İlk satırı atla
                    continue;
                }
                string[] sutunlar = satir.Split(',');
                if (sutunlar.Length == 4)
                {
                    KullaniciDTO kullanici = new KullaniciDTO
                    {
                        Ad = sutunlar[0],
                        Soyad = sutunlar[1],
                        //DogumTarihi = DateTime.ParseExact(sutunlar[2], "dd.MM.yyyy", null),
                        Sehir = sutunlar[3]
                    };
                    kullanicilar.Add(kullanici);
                }
            }
        }
        foreach (var kullanici in kullanicilar)
        {
            //Console.WriteLine($"Ad: {kullanici.Ad}, Soyad: {kullanici.Soyad}, Doğum Tarihi: {kullanici.DogumTarihi:dd.MM.yyyy}, Şehir: {kullanici.Sehir}");
        }
        return kullanicilar;
    }

    public static void CSVDosyasiniKutupaneIleOkuma()
    {
        ///CSV dosyasını okumak için CsvHelper kütüphanesini kullanabiliriz.
        ///CsvHelper, CSV dosyalarını kolayca okuyup yazmamızı sağlayan popüler bir .NET kütüphanesidir.
        ///CsvHelper'ı kullanarak CSV dosyasını okuyup KullaniciDTO nesnelerine dönüştürelim.
        using (var reader = new StreamReader("kullanici.csv", System.Text.Encoding.UTF8))
        {
             var okuyucu = new CsvHelper.CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture);

            var kullaniciListesi = okuyucu.GetRecords<KullaniciDTO>().ToList();

        }

     

    }

    public static void CSVDosyasinaKutuphaneIleYaz(List<KullaniciDTO> kullaniciListesi)
    {
        using (var sw = new StreamWriter("kullanici.csv", false, System.Text.Encoding.UTF8))
        {
            var yazici = new CsvHelper.CsvWriter(sw, System.Globalization.CultureInfo.InvariantCulture);
            yazici.WriteRecords(kullaniciListesi);
        }
    }
}
public class KullaniciDTO
{
    public string? Ad { get; set; }
    public string? Soyad { get; set; }
    //public DateTime? DogumTarihi { get; set; }
    public string? Sehir { get; set; }
}

///CSV dosyası ile çalışırken dikkat edilmesi gerekenler:
///1. Verilerin doğru formatta olması: CSV dosyasındaki verilerin doğru formatta
///Encoding (UTF-8) ve tarih formatı gibi) olması önemlidir.
///Hata olduğunda ele almak üzere try catch blokları kullanılabilir.
///CSV dosyalarını okuma yazma işlemlerini kolaylaştıran kütüphaneler (örneğin CsvHelper) kullanılabilir.