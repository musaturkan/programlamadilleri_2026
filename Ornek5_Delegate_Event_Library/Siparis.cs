using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek5_Delegate_Event_Library
{
    /// <summary>
    /// Siparişle ilgili olayların tanımlandığı sınıf. 
    /// Örneğin, sipariş verildiğinde, sipariş hazır olduğunda gibi olaylar burada tanımlanabilir.
    /// </summary>
    public class SiparisServis
    {
        ///public delegate void SiparisVerildiDelegate(string siparisDetayi);
        ///public event SiparisVerildiDelegate? SiparisVerildiEvent;

        public event Action<string>? SiparisVerildiEvent; //Action delegate türü kullanarak daha kısa ve okunabilir kod yazabiliriz.


        public void SiparisVer(string siparisDetayi)
        {
            Console.WriteLine($"Sipariş verildi: {siparisDetayi}");
            ///Veri tabanına verilen sipariş kaydedilir, ödeme işlemi yapılır gibi işlemler burada gerçekleştirilebilir.
                        
            SiparisVerildiEvent?.Invoke(siparisDetayi); //SiparisVerildiEvent tetiklenir ve abone olan metotlar çalışır.
        }
    }
}
