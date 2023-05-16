using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHT.Entity.DTOs
{
    public class VardiyaDto
    {
        public int Id { get; set; }

        /// <summary>
        /// Kullanici Tablosundan temin edilecek kullanıcıyı ifade eden kimlik değeri
        /// </summary>
        public string KullaniciIsim { get; set; }
        public string KullaniciSoyisim { get; set; }

        /// <summary>
        /// İşlem Tablosundan temin edilecek işlemi ifade eden kimlik değeri
        /// </summary>
        public string IslemAd { get; set; }

        /// <summary>
        /// Kullanıcıdan girdi olarak alınacak işlem saati
        /// </summary>
        public DateTime IslemSaati { get; set; }

        /// <summary>
        /// Vardiyanın aktiflik durumunu yönetmek ve örneğin bir giriş işleminın ardından çıkış 
        /// yapılmamışken tekrar giriş işlemi kaydedilmesini engellemek amacıyla kullanılır.
        /// Bir sürecin; 
        /// >başlangıcı için varsayılan olarak true (örneğin mola başlangıcı) 
        /// >bitişi için false (örneğin mola bitişi) atanır
        /// </summary><
        public bool IsActive { get; set; }
    }
}
