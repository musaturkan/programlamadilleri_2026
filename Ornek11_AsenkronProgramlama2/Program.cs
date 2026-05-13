using Ornek11_AsenkronProgramlama2.DTO;
using System.Threading.Tasks;

namespace Ornek11_AsenkronProgramlama2;
internal class Program
{
    private static async Task Main(string[] args)
    {
        //Hesap h = new Hesap();
        //h.HesaplamaBaslat();
        Hesap2 h2 = new Hesap2();
        //h2.Islem1Async();
        ///asenkron bir metot çağırdığımızda, o metot arka planda çalışmaya başlar ve biz diğer kodlara geçebiliriz.
        ///asekron metodun çalışmasını bitirmesi beklenmek isteniyorsa, o zaman await anahtar kelimesi kullanılır. await, asenkron bir işlemin tamamlanmasını beklemek için kullanılır.
        DateTime baslamaZamani = DateTime.Now;
        //await h2.Islem1Async();
        //await h2.Islem2Async();
        //await h2.Islem3Async();
        ///Await anahtar kelimesi asenkron işlemin tamamlanmasını beklerken, 
        ///diğer kodların çalışmasına izin verir. 
        ///Bu sayede uygulama daha responsive olur ve kullanıcı deneyimi iyileşir.
        //h2.Islem1Async().Wait();
        //h2.Islem2Async().Wait();
        //h2.Islem3Async().Wait();
        ServisApi servis = new ServisApi(); 
        //Task<Gonderi> sonuc = servis.VeriGetirAsync(1);
        //Task<Gonderi> sonuc2 = servis.VeriGetirAsync(2);
        //Task<Gonderi> sonuc3 = servis.VeriGetirAsync(3);
        //Task<string> userGetir = servis.UserGetirAsync(1);
        ////Task.WaitAll(sonuc, sonuc2, sonuc3,userGetir);
        ////await Task.WhenAll(sonuc, sonuc2, sonuc3,userGetir);
        //Gonderi gonderi1 = await sonuc; 
        //Gonderi gonderi2 = await sonuc2;
        //Gonderi gonderi3 = await sonuc3;

        //DateTime bitisZamani = DateTime.Now;
        //TimeSpan gecenSure = bitisZamani - baslamaZamani;
        //Console.WriteLine("Tüm işlemler tamamlandı.");
        //Console.WriteLine(gonderi2.title);
        //Console.WriteLine(gonderi1.title);
        //Console.WriteLine(gonderi3.title);
        //Console.WriteLine(userGetir.Result);
        //Console.WriteLine($"Toplam geçen süre: {gecenSure.TotalSeconds} saniye");

        ///Bir task dizisi oluşturularak dizi şeklinde WhenAll metoduna paramtere görnedirelibilr
        
        List<Task<Gonderi>> gonderiTasklari = new List<Task<Gonderi>>();
        for (int i = 1; i <= 100; i++)
        {
            gonderiTasklari.Add(servis.VeriGetirAsync(i));
        }

        Task.WhenAll(gonderiTasklari).Wait();
        //await  Task.WhenAll(gonderiTasklari);
        //Task.WaitAll(gonderiTasklari.ToArray());

        foreach (var gonderiTask in gonderiTasklari)
        {
                Gonderi gonderi = await gonderiTask;
                Console.WriteLine($"Gonderi ID: {gonderi.id}, User ID: {gonderi.userId}, Title: {gonderi.title}");
        }

        ///Asenkron metot .Net sisteminde nerdeyse standart hale gelmiştir. Asenkron programlama, uygulamaların daha hızlı ve daha responsive olmasını sağlar.
        ///Asenkron metot kullanmak her zaman  hızlı demek değildir. 
        ///Asenkron metotlar, özellikle I/O işlemleri gibi uzun süren işlemler için faydalıdır. 
        ///Ancak, CPU-bound işlemler için asenkron metot kullanmak performansı artırmayabilir ve hatta düşürebilir.
        ///Karmaşıklığa sebep olabilir. Asenkron programlama, özellikle yeni başlayanlar için karmaşık olabilir.
        ///Deadlock gibi sorunlara yol açabilir. Asenkron programlama, özellikle yanlış kullanıldığında, deadlock gibi sorunlara yol açabilir.
        ///Hata ayıklamak asenkron metotlarda zor olabilir. Asenkron programlama, özellikle hataların izlenmesi ve ayıklanması açısından zor olabilir.
        ///Çalışma soruları:
        ///Thread ve Task arasındaki fark nedir?
        ///async ve await anahtar kelimeleri ne işe yarar?
        ///await ile çağırılan bir asenkron metot senkron metot gibi mi çalışır? nasıl bir farkı vardır
        ///await ne işe yarar? await kullanmazsak ne olur?
        ///Asenkron metotların geri dönüş tipi nasıl tanımlanır? void, Task, Task<T> gibi farklı geri dönüş tipleri ne anlama gelir?
        ///Asenkron metottan dönen bir veriye nasıl erişilir? await kullanarak mı yoksa Task.Result gibi senkron bir şekilde mi?
    }
}