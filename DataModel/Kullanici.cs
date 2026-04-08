using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Kullanici
    {
        [Key]
        public int Id { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public DateTime? DogumTarihi { get; set; }
        //public string Adres { get; set; }
        //public string NufusIli { get; set; }
        //public string DogumYeri { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public string? KullaniciAdi { get; set; }
        public string? Parola { get; set; }
        public bool? Cinsiyet { get; set; }

    }
}
