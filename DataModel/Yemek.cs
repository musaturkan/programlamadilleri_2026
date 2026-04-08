using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Yemek
    {
        [Key]
        public int Id { get; set; }
        public string? Ad { get; set; }
        public decimal? Fiyat { get; set; }
        public int? Kalori { get; set; }
        public int? YemekTurId { get; set; }

        [ForeignKey("YemekTurId")]
        public YemekTur? YemekTur { get; set; }

        public virtual ICollection<Siparis>? Siparis { get; set; }
    }
}
