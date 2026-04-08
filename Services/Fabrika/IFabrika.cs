using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Fabrika
{
    public interface IFabrika
    {
        public IMarkaService MarkaServiceOlustur();
        public IUrunService UrunServiceOlustur();
    }
}
