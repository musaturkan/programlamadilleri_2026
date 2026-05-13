namespace Ornek11_AsenkronProgramlama;
internal class Program
{
    private static void Main(string[] args)
    {
        ///Zaman harcayan işlem örnekleri
        ///Dosya okuma/yazma işlemleri
        ///Veri tabanından okuma yazma işlemleri
        ///Web servis çağrıları
        ///Büyük işlem gerektiren hesaplamalar
        ///Bu işlemler yapılırken program işlemin bitmesini bekler. Sekron işlemler sıralı bir şekilde gerçekleşir.
        ///Bir işlem bitmeden diğerine geçilmez. Bu durum, özellikle zaman harcayan işlemler söz konusu olduğunda, 
        ///programın yanıt vermemesine veya yavaşlamasına neden olabilir.
        ///İşlem bitene kadar bekleniyorsa buna Senkron (Synchronous) programlama denir. 
        ///İşlem bitene kadar beklenmezse buna Asenkron (Asynchronous) programlama denir.
        ///
        ///Senkron çalışan metot çağrıları, işlemi tamamlayana kadar diğer kodların çalışmasını engeller.
        ///
        //DateTime baslamaZamani=DateTime.Now;
        //Islem1();
        //Islem2();
        //Islem3();
        //DateTime bitisZamani=DateTime.Now;

        //Console.WriteLine($"Toplam süre: {(bitisZamani - baslamaZamani).TotalSeconds} saniye");

        ///Metotları paralel olarak çalıştırmak için Thread, Task veya async/await yapıları kullanılabilir.
        ///Task.Run ile metotları paralel olarak çalıştırmak, işlemlerin birbirini beklemeden aynı anda başlamasını sağlar.
        DateTime baslamaZamani = DateTime.Now;
        Task gorev1 = Task.Run(() => Islem1());
        Task gorev2 = Task.Run(() => Islem2());
        Task gorev3 = Task.Run(() => Islem3());
        Task gorev4 = Task.Run(() => Islem2());

        Task.WaitAll(gorev1, gorev3);

        DateTime bitisZamani = DateTime.Now;
        Console.WriteLine($"Toplam süre: {(bitisZamani - baslamaZamani).TotalSeconds} saniye");

        ///Task sınıfı yerine Thread kullanılarak da paralel işlemler gerçekleştirilebilir, 
        ///ancak Task sınıfı daha yüksek seviyeli bir soyutlama sağlar ve daha kolay yönetilebilir.
        ///WaitAll metodu işlemlerin tamamlanmasını bekler. gorev1 ve gorev3 işlemleri tamamlanana kadar program bekler, ancak gorev2 ve gorev4 işlemleri devam eder.
        Thread isParcacigi =new Thread(() => Islem1());
        isParcacigi.Start();
        ///Paralel işlemler için Task kullanmak Thhread yönetimin .Net'e bırakır ve daha verimli kaynak kullanımı sağlar. Task'lar, 
        ///Thread havuzunu kullanarak işlemleri yönetir ve gerektiğinde yeni Thread'ler oluşturur.
    }

    public static void Islem1()
    {
        Console.WriteLine("İşlem 1 başladı.");
        Thread.Sleep(2000); // 2 saniye bekleme simülasyonu
        Console.WriteLine("İşlem 1 bitti.");
    }
    public static void Islem2()
    {
        Console.WriteLine("İşlem 2 başladı.");
        Thread.Sleep(3000); // 3 saniye bekleme simülasyonu
        Console.WriteLine("İşlem 2 bitti.");
    }
    public static void Islem3()
    {
        Console.WriteLine("İşlem 3 başladı.");
        Thread.Sleep(1000); // 2 saniye bekleme simülasyonu
        Console.WriteLine("İşlem 3 bitti.");
    }
}