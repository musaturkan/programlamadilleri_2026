using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek12_2_Ornekler
{
    public interface IMesaj
    {
        public void Gonder();
        // Mesaj gönderme işlemi burada gerçekleştirilecek
        public void MesajAl();
        // Mesaj alma işlemi burada gerçekleştirilecek
    }
}
