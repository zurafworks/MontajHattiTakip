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
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MontajHattiTakip;Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Kullanici>().HasData(
                new Kullanici { Id = 1, Isim = "default", Soyisim = "admin", KullaniciAdi = "admin", Sifre = "admin", YoneticiMi = true },
                new Kullanici { Id = 2, Isim = "default", Soyisim = "user", KullaniciAdi = "user", Sifre = "user", YoneticiMi = false }
            );
            modelBuilder.Entity<Islem>().HasData(
                new Islem { Id = 1, IslemAdi = "İş Başlangıç" },
                new Islem { Id = 2, IslemAdi = "İş Bitiş" },
                new Islem { Id = 3, IslemAdi = "Mola Başlangıç" },
                new Islem { Id = 4, IslemAdi = "Mola Bitiş" }
           );
        }
    }
}
