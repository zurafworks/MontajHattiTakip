using MHT.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHT.DataAccess.Concrete.Contexts
{
    public class MhtContext : DbContext
    {
        public DbSet<Islem> Islemler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Kullanim> Kullanimlar { get; set; }
        public DbSet<Makine> Makineler { get; set; }
        public DbSet<Vardiya> Vardiyalar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ZrfMontajHattiTakip.db");
        }
    }
}
