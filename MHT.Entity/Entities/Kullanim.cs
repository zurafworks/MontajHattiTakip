using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zurafworks.Shared.Entities.Abstract;

namespace MHT.Entity.Entities
{
    /// <summary>
    /// Kullanım tablosu hangi çalışanın hangi makineyi hangi saatlerde kullandığını takip etmek
    /// ve yönetmek amacıyla kullanılır.
    /// 
    /// Örneğin; A kişisi B Makinesini Saat 10:00 ile 12:00 arasında C amacıyla kullandı.
    /// </summary>
    public class Kullanim:IEntity
    {
        public int Id { get; set; }

        /// <summary>
        /// İlgili çalışanın kimliği
        /// </summary>
        public int KullaniciId { get; set; }

        /// <summary>
        /// İlgili makinenin kimliği
        /// </summary>
        public int MakineId { get; set; }

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

        /// <summary>
        /// Makinenin Kullanımda olup olmadığını takip etmek ve kullanımdaki bir makinenin
        /// kullanımı bir çalışan tarafından devam etmekteyken başka bir çalışanın onu kullanmaya
        /// başlamasının beyanını engellemek için kullanılır.
        /// </summary>
        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }
    }
}
