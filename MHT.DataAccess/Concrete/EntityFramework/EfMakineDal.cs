using MHT.DataAccess.Abstract;
using MHT.DataAccess.Concrete.Contexts;
using MHT.Entity.DTOs;
using MHT.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zurafworks.Shared.Data.Concrete.EntityFramework;

namespace MHT.DataAccess.Concrete.EntityFramework
{
    public class EfMakineDal : EfEntityRepositoryBase<Makine>, IMakineDal
    {
        public EfMakineDal(DbContext context) : base(context)
        {
        }
        public List<MakineDto> GetMakineDtos()
        {
            using (MhtContext db = new MhtContext())
            {
                var query = from m in db.Makineler
                            where m.Isdeleted == false
                            select new MakineDto
                            {
                                Id = m.Id,
                                MakineAdi = m.MakineAdi
                            };
                return query.ToList();
            }
        }
    }
}
