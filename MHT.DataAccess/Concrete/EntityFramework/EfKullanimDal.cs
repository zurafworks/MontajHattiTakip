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
    public class EfKullanimDal : EfEntityRepositoryBase<Kullanim>, IKullanimDal
    {
        public EfKullanimDal(DbContext context) : base(context)
        {
        }

        public IList<KullanimDto> GetAllKullanimDto()
        {
            using (MhtContext context = new MhtContext())
            {
                var query = from k in context.Kullanimlar
                            join m in context.Makineler
                            on k.MakineId equals m.Id
                            join kk in context.Kullanicilar
                            on k.KullaniciId equals kk.Id
                            where k.IsDeleted == true
                            select new KullanimDto
                            {
                                Id = k.Id,
                                KullaniciAd = kk.Isim,
                                MakinaAd = m.MakineAdi,
                                Aciklama = k.Aciklama,
                                Baslangic = k.Baslangic,
                                KullaniciSoyad = kk.Soyisim,
                                Bitis = k.Bitis,
                                IsActive = k.IsActive
                            };
                return query.ToList();
            }
        }
    }
}
