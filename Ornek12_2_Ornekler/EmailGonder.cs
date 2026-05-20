using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek12_2_Ornekler
{
    public class EmailGonder : IMesaj
    {
        public void Gonder()
        {
            Console.WriteLine("Email gönderiliyor...");
            // Email gönderme işlemi burada gerçekleştirilecek
            Console.WriteLine("Email gönderildi.");
        }

        public void MesajAl()
        {
            Console.WriteLine("Email alınıyor...");
            // Email alma işlemi burada gerçekleştirilecek
            Console.WriteLine("Email alındı.");
        }
    }

    public class SmsGonder : IMesaj
    {
        public void Gonder()
        {
            Console.WriteLine("SMS gönderiliyor...");
            // SMS gönderme işlemi burada gerçekleştirilecek
            Console.WriteLine("SMS gönderildi.");
        }
        public void MesajAl()
        {
            Console.WriteLine("SMS alınıyor...");
        }
    }
}
