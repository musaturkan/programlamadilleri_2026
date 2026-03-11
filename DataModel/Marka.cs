using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel;

[Table("Marka")]
public class Marka
{
    [Key]
    public int Id { get; set; }
    public string? Ad { get; set; }
    public virtual ICollection<Urun>? Urun { get; set; } //Navigation property
}

