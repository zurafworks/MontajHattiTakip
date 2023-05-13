using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zurafworks.Shared.Entities.Abstract;

namespace MHT.Entity.Entities
{
    /// <summary>
    /// İşlemler Vardiya ile ilgili girdiler için kullanılır. Örneğin 
    /// Çalışan işe başladığı saatte Giriş isimli işlemi seçerek başlangıç
    /// saatini beyan edebilir.
    /// </summary>
    public class Islem:IEntity
    {
        public int Id { get; set; }

        /// <summary>
        /// İşlemin Adı, Örneğin giriş, çıkış, mola başlangıç vb.
        /// </summary>
        public string IslemAdi { get; set; }

        public bool IsDeleted { get; set; }
    }
}
