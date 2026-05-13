using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek11_AsenkronProgramlama2
{
    public class Hesap
    {
        public void HesaplamaBaslat()
        {
            DateTime baslamaZamani = DateTime.Now;
            Task gorev1 = Task.Run(() => Islem1());
            Task gorev2 = Task.Run(() => Islem2());
            Task gorev3 = Task.Run(() => Islem3());
            Task gorev4 = Task.Run(() => Islem2());
            Task.WaitAll(gorev1,gorev2, gorev3, gorev4);
            DateTime bitisZamani = DateTime.Now;
            Console.WriteLine($"Toplam süre: {(bitisZamani - baslamaZamani).TotalSeconds} saniye");
        }
        public void Islem1()
        {
            Console.WriteLine("İşlem 1 başladı.");
            Thread.Sleep(2000); // 2 saniye bekleme simülasyonu
            Console.WriteLine("İşlem 1 bitti.");
        }
        public void Islem2()
        {
            Console.WriteLine("İşlem 2 başladı.");
            Thread.Sleep(3000); // 3 saniye bekleme simülasyonu
            Console.WriteLine("İşlem 2 bitti.");
        }
        public void Islem3()
        {
            Console.WriteLine("İşlem 3 başladı.");
            Thread.Sleep(1000); // 2 saniye bekleme simülasyonu
            Console.WriteLine("İşlem 3 bitti.");
        }
    }
}
