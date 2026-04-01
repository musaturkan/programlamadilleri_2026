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
       
        public void HareketEt(int km)
        {
           Console.WriteLine($"{Marka} {Model} Hareket etti.");
        }

        public void YakitEkle(int litre)
        {
            Console.WriteLine($"{litre} litre yakıt eklendi.");
        }

        ///Bir metoda paramater olarak başka bir metot verilebilir. 
        ///Bu sayede o metot çalıştırıldığında, parametre olarak verilen metot da çalıştırılır.
        ///Bu işlemi gerçekleştirmek için C# dilinde delegate yapısı kullanılır.
        ///Delegate: Metot referanslarını tutan bir türdür. 
        ///Bir delegate, belirli bir imzaya sahip metotları temsil eder ve bu metotları çağırmak için kullanılabilir.

        delegate void HareketDelegate(int km);
    }
}
