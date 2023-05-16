using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHT.Entity.DTOs
{
    public class KullaniciDto
    {
        public int Id { get; set; }

        /// <summary>
        /// Kullanıcının giriş yaparken kullanacağı Kullanıcı Adı
        /// </summary>
        public string KullaniciAdi { get; set; }

        /// <summary>
        /// Kullanıcının şifresi
        /// </summary>
        public string Sifre { get; set; }

        /// <summary>
        /// Listelenecek İsmi
        /// </summary>
        public string Isim { get; set; }

        /// <summary>
        /// Listelenecek Soyismi
        /// </summary>
        public string Soyisim { get; set; }

        /// <summary>
        /// Kullanıcı Statüsü. Bu değerin "true" olması kullanıcının bir yönetici olduğunu 
        /// ifade eder ve takip vb işlemlerini inceleyebileceği anlamına gelir. 
        /// 
        /// Bu değerin "false" olması ise kullanıcının bir çalışan olduğunu ve Giriş çıkış 
        /// saatlerini, mola bilgisini ve makine kullanım girdilerini yapabileceği anlamına gelir.
        /// </summary>
        public bool YoneticiMi { get; set; }


    }
}
