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
    public class EfVardiyaDal : EfEntityRepositoryBase<Vardiya>, IVardiyaDal
    {
        
        public EfVardiyaDal(DbContext context) : base(context)
        {
        }

        public IQueryable<VardiyaDto> GetAllVardiyaDto()
        {
            using (MhtContext context = new MhtContext())
            {
                var query = from v in context.Vardiyalar
                            join k in context.Kullanicilar
                            on v.KullaniciId equals k.Id
                            join i in context.Islemler
                            on v.IslemId equals i.Id
                            select new VardiyaDto
                            {
                                Id = v.Id,
                                IslemAd = i.IslemAdi,
                                KullaniciIsim = k.Isim,
                                KullaniciSoyisim = k.Soyisim,
                                IslemSaati = v.IslemSaati,
                                IsActive = v.IsActive
                            };
                return query;
            }
        }
    }
}
