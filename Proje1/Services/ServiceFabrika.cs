using Services.Fabrika;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceFabrika:IFabrika
    {
      public IUrunService UrunServiceOlustur()
        {
            return new UrunService2();
        }
        public IMarkaService MarkaServiceOlustur()
        {
            return new MarkaService();
        }
    }
}
