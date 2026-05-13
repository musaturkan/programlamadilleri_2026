using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///Asenkron programlamada async ve await anahtar kelimeleri, 
///asenkron işlemleri daha kolay ve okunabilir hale getirmek için kullanılır.
///Kendisi asenkron çalışan bir metot tanımlamak için async anahtar kelimesi kullanılır.
///Asenkron bir metot, genellikle bir Task veya Task<T> döner ve await anahtar kelimesi ile çağrılır.

namespace Ornek11_AsenkronProgramlama2
{
    public class Hesap2
    {
        public async Task HesaplamaBaslatAsync()
        {
            DateTime baslamaZamani = DateTime.Now;
            Task gorev1 = Islem1Async();
            Task gorev2 = Islem2Async();
            Task gorev3 = Islem3Async();
            Task gorev4 = Islem2Async();
            await Task.WhenAll(gorev1, gorev2, gorev3, gorev4);
            DateTime bitisZamani = DateTime.Now;
            Console.WriteLine($"Toplam süre: {(bitisZamani - baslamaZamani).TotalSeconds} saniye");
        }
        public async Task Islem1Async()
        {
            Console.WriteLine("İşlem 1 başladı.");
            await Task.Delay(2000); // 2 saniye bekleme simülasyonu
            Console.WriteLine("İşlem 1 bitti.");
        }
        public async Task Islem2Async()
        {
            Console.WriteLine("İşlem 2 başladı.");
            await Task.Delay(3000); // 3 saniye bekleme simülasyonu
            Console.WriteLine("İşlem 2 bitti.");
        }
        public async Task Islem3Async()
        {
            Console.WriteLine("İşlem 3 başladı.");
            await Task.Delay(1000); // 1 saniye bekleme simülasyonu
            Console.WriteLine("İşlem 3 bitti.");
        }


    }
}
