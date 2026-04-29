using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek9_2JsonDosyalarlaCalismak.Models
{
    public class KullaniciDTO
    {
        public int Id { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? Sehir { get; set; }
        public int DogumYili { get; set; }
    }
}
