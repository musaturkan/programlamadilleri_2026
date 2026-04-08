using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Masa
    {
       
        [Key]
        public int Id { get; set; }
        public string? Ad { get; set; }
        public string? Kodu { get; set; }
        public int? Kapasite { get; set; }
        public virtual ICollection<Siparis>? Siparis { get; set; }
    }
}
