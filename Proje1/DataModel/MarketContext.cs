using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel;

/// <summary>
/// Veri tabanýnýn temsil eden sýnýftýr. Sorgular bu sýnýf üzerinden yapýlýr.
/// DbContext nesnesinden türetildiði için sorgulanabilir bir veri tabaný sýnýfýdýr
/// </summary>
public class MarketContext : DbContext
{
    public DbSet<Urun> Urun { get; set; }
    public DbSet<Marka> Marka { get; set; }
    public DbSet<Kullanici> Kullanici { get; set; }

    /// <summary>
    /// Baðlantý cümleciði bildirimi bu metot içinde yapýlabilir.
    /// </summary>
    /// <param name="optionsBuilder"></param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=Market;Trusted_Connection=True;TrustServerCertificate=True");
        //optionsBuilder.UseNpgsql("postgreSQL baðlantý cümlesi");

    }
}