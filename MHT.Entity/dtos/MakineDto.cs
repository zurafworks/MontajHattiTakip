using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHT.Entity.DTOs
{
    public class MakineDto
    {
        public int Id { get; set; }

        /// <summary>
        /// İşyeri bünyesindeki makinenin adı
        /// </summary>
        public string MakineAdi { get; set; }
    }
}
