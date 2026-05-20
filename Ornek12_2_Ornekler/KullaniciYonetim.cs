using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek12_2_Ornekler
{
    public class KullaniciYonetim
    {
        private IMesaj mesajGonder;
        public KullaniciYonetim(IMesaj _mesajGonder)
        {
            mesajGonder = _mesajGonder;
        }
        public void BildirimGonder()
        {
            mesajGonder.Gonder();
        }
    }
}
