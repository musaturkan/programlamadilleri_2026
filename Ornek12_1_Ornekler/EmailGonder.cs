using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek12_1_Ornekler
{
    public class EmailGonder:IMesaj
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

    public class SmsGonder:IMesaj
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

    public class BildirimGonder : IMesaj
    {
        public void Gonder()
        {
            Console.WriteLine("Bildirim gönderiliyor...");
        }

        public void MesajAl()
        {
            Console.WriteLine("Bildirim alınıyor...");
        }
    }


    public class KullaniciYonetim
    {
        //private EmailGonder emailGonder =new EmailGonder();
        //public SmsGonder smsGonder=new SmsGonder();
        private IMesaj mesajGonder;
        public KullaniciYonetim(IMesaj _mesajGonder)
        {
            mesajGonder = _mesajGonder;
        }
        public void BildirimGonder()
        {
            Console.WriteLine("Kullanıcı bildirimi gönderiliyor...");
            // Kullanıcı bildirimi gönderme işlemi burada gerçekleştirilecek
            //emailGonder.Gonder();
            //smsGonder.Gonder();
            mesajGonder.Gonder();
            Console.WriteLine("Kullanıcı bildirimi gönderildi.");
        }

    }
}
