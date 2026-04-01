using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel;

public class Siparis
{
    [Key]
    public int Id { get; set; }
    public int? KullaniciId { get; set; }
    public int? UrunId { get; set; }
    public DateTime Tarih { get; set; }

    [ForeignKey("UrunId")]
    public Urun? Urun { get; set; }

    [ForeignKey("KullaniciId")]
    public Kullanici? Kullanici { get; set; }
}
