using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek12_4_Ornekler
{
    public class Ogrenci
    {
        ///not ilan işlemi için bir olay tanımlamaka istiyoruuz.
        ///Böylece bu sınıfı kullanak yazılımcı bu olaya abone olabilir ve not ilan işlemi gerçekleştiğinde bu olaya abone olan metotlar çalışır.

        public delegate void KayitSilmeDelegate(int ogrenciId);
        public event KayitSilmeDelegate KayitSilmeEvent;

        public event Action<int, int> NotIlanEvent;

        public void NotIlan(int dersId, int not)
        {
            ///not ilan işlemelri yapılır
            Console.WriteLine($"Ders Id: {dersId}, Not: {not} ilan edildi.");
            NotIlanEvent?.Invoke(dersId, not);
        }

        public void KayitSil(int ogrenciId)
        {
            ///kayıt silme işlemleri yapılır
            Console.WriteLine($"Öğrenci Id: {ogrenciId} kaydı silindi.");           
            KayitSilmeEvent?.Invoke(ogrenciId);
        }
    }
}
