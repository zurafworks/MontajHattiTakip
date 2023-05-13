using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zurafworks.Shared.Entities.Abstract;

namespace MHT.Entity.Entities
{
    /// <summary>
    /// Vardiyalar hangi çalışanın hangi işlemi saat kaçta gerçekleştirdiğini yönetir.
    /// Örneğin A çalışanı saat 17:30'da Çıkış işlemi gerçekleştirdi
    /// </summary>
    public class Vardiya:IEntity
    {
        public int Id { get; set; }

        /// <summary>
        /// Kullanici Tablosundan temin edilecek kullanıcıyı ifade eden kimlik değeri
        /// </summary>
        public int KullaniciId { get; set; }

        /// <summary>
        /// İşlem Tablosundan temin edilecek işlemi ifade eden kimlik değeri
        /// </summary>
        public int IslemId { get; set; }

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
        /// </summary>
        public bool IsActive { get; set; }

        public bool Isdeleted { get; set; }
    }
}
