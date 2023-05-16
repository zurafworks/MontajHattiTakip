using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHT.Entity.DTOs
{
    public class KullanimDto
    {
        public int Id { get; set; }

        /// <summary>
        /// İlgili çalışanın kimliği
        /// </summary>
        public string KullaniciAd { get; set; }
        public string KullaniciSoyad { get; set; }
        /// <summary>
        /// İlgili makinenin kimliği
        /// </summary>
        public string MakinaAd { get; set; }
        /// <summary>
        /// Kullanım başlama saati
        /// </summary>
        public DateTime Baslangic { get; set; }

        /// <summary>
        /// Kullanım bitiş saati
        /// </summary>
        public DateTime? Bitis { get; set; }

        /// <summary>
        /// Kullanım açıklaması. Buraya çalışan makineyi kullanım sebebini yazacak.
        /// </summary>
        public string Aciklama { get; set; }
        public bool IsActive { get; set; }
    }
}
