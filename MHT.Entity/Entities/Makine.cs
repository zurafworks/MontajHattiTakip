using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zurafworks.Shared.Entities.Abstract;

namespace MHT.Entity.Entities
{
    /// <summary>
    /// Makineler çalışanların iş sırasında kullandığı araçları temsil eder. 
    /// Örneğin; A kişisi B ismindeki makineyi saat 13:30'da C amacıyla kullanmaya başladı. 
    /// gibi beyanlarda bulunmak için Çalışan kullandığı makineyi, buraya kayıtlı makineler 
    /// arasından seçer ve vakit bildirir.
    /// </summary>
    public class Makine: IEntity
    {
        public int Id { get; set; }

        /// <summary>
        /// İşyeri bünyesindeki makinenin adı
        /// </summary>
        public string MakineAdi { get; set; }

        public bool Isdeleted { get; set; }
    }
}
