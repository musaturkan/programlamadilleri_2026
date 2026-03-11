using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel;

public class Urun
{
    [Key]
    public int Id { get; set; }

    //[Column("urun_adi")]
    public string? Ad { get; set; }
    public decimal? Fiyat { get; set; }

    public int? MarkaId { get; set; }

    [ForeignKey("MarkaId")]
    public Marka? Marka { get; set; }
}

