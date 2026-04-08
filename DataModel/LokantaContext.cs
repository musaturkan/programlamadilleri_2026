using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class LokantaContext:DbContext
    {
        public DbSet<Masa>? Masa {  get; set; }
        public DbSet<YemekTur>? YemekTur { get; set; }
        public DbSet<Yemek>? Yemek { get; set; }
        public DbSet<Siparis>? Siparis { get; set; }
        public DbSet<Kullanici> Kullanici { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Lokanta;Trusted_Connection=True;TrustServerCertificate=True");
            
        }
    }
}
