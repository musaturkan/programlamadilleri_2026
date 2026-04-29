
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
        StreamWriter yazici = new StreamWriter("ornek.txt", true); 
        yazici.WriteLine("Merhaba Dünya");
        yazici.WriteLine("Bu bir dosya işlemi örneğidir.");
        yazici.WriteLine("C# programlama dilinde dosya işlemleri yapmak çok kolaydır.");
        yazici.Close();

        DosyaYaz("Yeni bir mesajı dosyaya yazıyorum.");
        DosyaYaz("Bu mesaj da dosyaya yazılıyor.");
        DosyaYaz("Dosya işlemleri çok kullanışlıdır.");

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
}