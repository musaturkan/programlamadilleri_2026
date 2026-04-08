using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek5_Delegate_Event_Library
{
    public class Arac
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }

        public delegate void YakitYuklemeBasliyorDelegate(int litre);
        public event YakitYuklemeBasliyorDelegate? YakitYuklemeBasliyorEvent;

        public delegate void YakitYuklemeBittiDelegate(int litre);
        public event YakitYuklemeBittiDelegate? YakitYuklemeBittiEvent;

        public delegate void HareketDelegate(int km);
        public event HareketDelegate? HareketEvent;
        public void HareketEt(int km)
        {
           Console.WriteLine($"{Marka} {Model} Hareket etti.");
           HareketEvent?.Invoke(km); //HareketEvent tetiklenir ve abone olan metotlar çalışır.
            ///Bir sınıf içinde bir olay yani bir even tanımı varsa o olayın ne zaman tetikleneceği 
            ///o sınıfın sorumluluğundadır.
            ///Olay tetiklendiğinde, o olaya abone olan metotlar çalışır.
        }

        public void YakitEkle(int litre)
        {
            YakitYuklemeBasliyorEvent?.Invoke(litre); //YakitYuklemeBasliyorEvent tetiklenir ve abone olan metotlar çalışır.
            
            Console.WriteLine($"{litre} litre yakıt eklendi.");
            HareketDelegate hareketDelegate = HareketEt;
            hareketDelegate(10); // HareketEt metodunu çağırır ve 10 km hareket eder.

            YakitYuklemeBittiEvent?.Invoke(litre); //YakitYuklemeBittiEvent tetiklenir ve abone olan metotlar çalışır.
        }

        ///Bir metoda paramater olarak başka bir metot verilebilir. 
        ///Bu sayede o metot çalıştırıldığında, parametre olarak verilen metot da çalıştırılır.
        ///Bu işlemi gerçekleştirmek için C# dilinde delegate yapısı kullanılır.
        ///Delegate: Metot referanslarını tutan bir türdür. 
        ///Bir delegate, belirli bir imzaya sahip metotları temsil eder ve bu metotları çağırmak için kullanılabilir.


        ///Event: Bir olay olduğunda çalışan delegate türüdür.
        ///Event tanımlanırken, delegate türü belirtilir ve bu event'e abone olan metotlar, event tetiklendiğinde çalışır.
        ///Bir event tanımlayabilmek için bir delegate türünün tanımlanması gerekir.
        ///Event, bir sınıf içinde tanımlanır ve o sınıfın sorumluluğundadır.
        ///Eventın ne zaman tetikleneceğini sınıf içinde belirler.
        ///Bir sınıfın olayına abone olan metotlar eventın tanımlanırken belirtilen delegate türüen uygun olması gerekir.

    }
}
