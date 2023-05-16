using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zurafworks.Shared.Entities.Abstract;

namespace MHT.Entity.DTOs
{
    public class IslemDto:IDto
    {
        public int Id { get; set; }

        /// <summary>
        /// İşlemin Adı, Örneğin giriş, çıkış, mola başlangıç vb.
        /// </summary>
        public string IslemAdi { get; set; }
    }
}
