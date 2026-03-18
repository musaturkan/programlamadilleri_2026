using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Fabrika
{
    public interface IService
    {
        void Yazdir(int id = 1);
        //void Yazdir(DataModel.Urun urun);
    }
}
