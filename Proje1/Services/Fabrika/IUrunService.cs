using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Fabrika
{
    public interface IUrunService :IService
    {
        void UrunEkle(DataModel.Urun yeniUrun);
        void UrunGuncelle(DataModel.Urun guncellenecekUrun);
        void UrunSil(int id);
  
    }
}
