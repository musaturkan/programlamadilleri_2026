using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek12_3_Ornekler.Entity
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? Email { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public string? TcKimlikNo { get; set; }
        public string? Aciklama { get; set; }
        public string? KullaniciAdi { get; set; }
        public string? Parola { get; set; }
    }
}
