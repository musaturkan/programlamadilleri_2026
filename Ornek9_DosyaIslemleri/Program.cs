
namespace Ornek9_DosyaIslemleri;
using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        ///Dosya İşlemleri
        ///Dosyaya veri yazmak
        ///Dosyadan veri okumak
        ///Basit loglama işlemi yapmak
        ///RAM bellekteki bilgilerin kalıcı hale getirilmesi için dosya işlemleri yapılır.
        ///Dosyaya yazmak için StreamWriter sınıfı kullanılır.
        ///StreamWriter sınıfı, System.IO namespace'i içinde bulunur.
        ///StreamWriter sınıfı, dosyaya veri yazmak için kullanılır.
        ///StreamReader sınıfı, dosyadan veri okumak için kullanılır.
        ///StreamWriter sınfı oluşturulurken ikinci parametre true verilirse dosya ekleme modunda açılır, 
        ///yani dosyanın mevcut içeriği silinmez ve yeni veriler dosyanın sonuna eklenir. 
        /// Eğer ikinci parametre false veya hiç verilmezse, dosya yazma modunda açılır 
        /// ve mevcut içerik silinir.
        //StreamWriter yazici = new StreamWriter("ornek.txt", true); 
        //yazici.WriteLine("Merhaba Dünya");
        //yazici.WriteLine("Bu bir dosya işlemi örneğidir.");
        //yazici.WriteLine("C# programlama dilinde dosya işlemleri yapmak çok kolaydır.");
        //yazici.Close();

        //DosyaYaz("Yeni bir mesajı dosyaya yazıyorum.");
        //DosyaYaz("Bu mesaj da dosyaya yazılıyor.");
        //DosyaYaz("Dosya işlemleri çok kullanışlıdır.");

        //DosyaOku();
        DosyaYazFile("Birinci mesaj");
        DosyaYazFile("İkinci mesaj");
        DosyaYazFile("Üçüncü mesaj");
    }

    public static void DosyaYaz(string mesaj)
    {
        //StreamWriter yazici = new StreamWriter("ornek.txt", true);
        //yazici.WriteLine($"{DateTime.Now}: {mesaj}");
        //yazici.Close();
        using (StreamWriter yazici2 = new StreamWriter("ornek.txt", true))
        {
            yazici2.WriteLine($"{DateTime.Now}: {mesaj}");
            yazici2.Close();
        }
    }

    public static void DosyaOku()
    {
        ///Dosyadan veri okumak için StreamReader sınıfı kullanılır.
        ///ReadToEnd() metodu, dosyanın tamamını okuyarak bir string olarak döndürür.
        ///ReadLine() metodu, dosyadan bir satır okuyarak bir string olarak döndürür.
        ///ReadLine() metodu, dosyanın sonuna gelene kadar her çağrıldığında bir sonraki satırı okur.
        StreamReader okuyucu = new StreamReader("ornek.txt");
        //string icerik = okuyucu.ReadToEnd();
        //string icerik = okuyucu.ReadLine() ;        
        //Console.WriteLine(icerik);
        //icerik = okuyucu.ReadLine();
        //Console.WriteLine(icerik);
        int sayac = 1;
        while (!okuyucu.EndOfStream)
        {
            string satir = okuyucu.ReadLine();
            Console.WriteLine($"{sayac}.Satır: { satir}");
            sayac++;
        }
        okuyucu.Close();
    }

    ///File sınıfı, dosya işlemleri için statik metotlar sağlar.
    ///
    public static void DosyaYazFile(string mesaj)
    {
        ///File.AppendAllText() metodu, belirtilen dosyaya metin ekler. 
        ///Eğer dosya mevcut değilse, yeni bir dosya oluşturur.
        ///

        //File.AppendAllText("ornek2.txt", mesaj);                
        File.WriteAllLines("ornek3.txt", new string[] { "Birinci satır", "İkinci satır", "Üçüncü satır" });
    }
     public static void DosyaOkuFile()
    {
        ///File.ReadAllText() metodu, belirtilen dosyanın tamamını okuyarak bir string olarak döndürür.
        string icerik = File.ReadAllText("ornek2.txt");
        File.GetLastAccessTime("ornek2.txt");
        Console.WriteLine(icerik);
    }

    /// <summary>
    /// File sınıfının ReadAllLines() metodu, belirtilen dosyanın tüm satırlarını okuyarak 
    /// bir string dizisi olarak döndürür.
    /// </summary>
    public static void DosyaOkuFileLines()
    {
        ///File.ReadAllLines() metodu, belirtilen dosyanın tüm satırlarını okuyarak 
        ///bir string dizisi olarak döndürür.
        string[] satirlar = File.ReadAllLines("ornek3.txt");
        foreach (string satir in satirlar)
        {
            Console.WriteLine(satir);
        }
    }
    
    public void DosyaBilgi()
    {
        ///FileInfo sınıfı, dosya hakkında bilgi almak ve dosya işlemleri yapmak için kullanılır.
        ///FileInfo sınıfı, System.IO namespace'i içinde bulunur.
        ///FileInfo sınıfı, bir dosyanın adı, uzantısı, boyutu, oluşturulma tarihi gibi bilgileri sağlar.
        ///FileInfo sınıfı, dosya üzerinde kopyalama, taşıma, silme gibi işlemler yapabilir.
        FileInfo dosyaBilgi = new FileInfo("ornek.txt");
        Console.WriteLine($"Dosya Adı: {dosyaBilgi.Name}");
        Console.WriteLine($"Dosya Uzantısı: {dosyaBilgi.Extension}");
        Console.WriteLine($"Dosya Boyutu: {dosyaBilgi.Length} bytes");
        Console.WriteLine($"Oluşturulma Tarihi: {dosyaBilgi.CreationTime}");
        Console.WriteLine($"Son Erişim Tarihi: {dosyaBilgi.LastAccessTime}");
        
    }

    public void DosyaIslemleri()
    {
        ///FileInfo sınıfı, dosya üzerinde kopyalama, taşıma, silme gibi işlemler yapabilir.
        FileInfo dosyaBilgi = new FileInfo("ornek.txt");
        //Dosyayı kopyala
        dosyaBilgi.CopyTo("ornek_kopya.txt", true); //true parametresi, hedef dosya zaten varsa üzerine yazılmasını sağlar.
        //Dosyayı taşı
        dosyaBilgi.MoveTo("ornek_tasindi.txt");
        //Dosyayı sil
        dosyaBilgi.Delete();
        ///Silme işlemi yaparken FileInfo sınıfının Delete() metodu kullanılır.
        ///File.Delete("ornek_kopya.txt");
    }
}