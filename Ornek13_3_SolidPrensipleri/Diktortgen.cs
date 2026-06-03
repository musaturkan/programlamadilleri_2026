using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_13_3_SolidPrensipleri
{
    public class Diktortgen
    {
        public virtual int Genislik { get; set; }
        public virtual int Yukseklik { get; set; }
    }

    public class Kare : Diktortgen
    {
        public override int Genislik
        {
            get { return base.Genislik; }
            set
            {
                base.Genislik = value;
                base.Yukseklik = value; // Kare olduğunda genişlik ve yükseklik eşit olmalıdır
            }
        }
        public override int Yukseklik
        {
            get { return base.Yukseklik; }
            set
            {
                base.Yukseklik = value;
                base.Genislik = value; // Kare olduğunda genişlik ve yükseklik eşit olmalıdır
            }
        }
    }
}
