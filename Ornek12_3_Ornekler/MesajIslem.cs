using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek12_3_Ornekler
{
    public class MesajIslem
    {
        public void MesajGonder<T>(T mesaj) where T : IMesaj
        {
            mesaj.Gonder();
        }
    }
}
