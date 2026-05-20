using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek12_1_Ornekler
{
    public interface IMesaj
    {
        public void Gonder();
        //{
        //    Console.WriteLine("Mesaj gönderiliyor...");
        //    // Mesaj gönderme işlemi burada gerçekleştirilecek
        //    Console.WriteLine("Mesaj gönderildi.");
        //}

        public void MesajAl();
        
    }
}
