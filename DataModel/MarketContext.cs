using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel;

/// <summary>
/// Veri tabanının temsil eden sınıftır. Sorgular bu sınıf üzerinden yapılır.
/// DbContext nesnesinden türetildiği için sorgulanabilir bir veri tabanı sınıfıdır
/// </summary>
public class MarketContext:DbContext
{
    public DbSet<Urun> Urun { get; set; }
    public DbSet<Marka> Marka { get; set; }

    /// <summary>
    /// Bağlantı cümleciği bildirimi bu metot içinde yapılabilir.
    /// </summary>
    /// <param name="optionsBuilder"></param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {     
        optionsBuilder.UseSqlServer("Server=.;Database=Market;Trusted_Connection=True;TrustServerCertificate=True");
        //optionsBuilder.UseNpgsql("postgreSQL bağlantı cümlesi");
      
    }
}

