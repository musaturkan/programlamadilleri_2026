using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class YemekTur
    {
        [Key]
        public int Id { get; set; }
        public string? Ad { get; set; }
        public virtual ICollection<Yemek>? Yemek { get; set; }
    }
}
