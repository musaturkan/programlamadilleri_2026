using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Fabrika
{
    public interface IMarkaService
    {
        void MarkaEkle(DataModel.Marka yeniMarka);
        void MarkaSil(int id);
        void MarkaGuncelle(DataModel.Marka guncellenecekMarka);
    }
}
