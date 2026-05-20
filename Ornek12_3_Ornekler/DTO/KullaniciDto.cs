using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek12_3_Ornekler.DTO
{
    public class KullaniciDto
    {
        public int Id { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public DateTime? KayitTarihi { get; set; }
    }
}
