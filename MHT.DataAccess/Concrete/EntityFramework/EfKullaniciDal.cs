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
    public class EfKullaniciDal : EfEntityRepositoryBase<Kullanici>, IKullaniciDal
    {
        public EfKullaniciDal(DbContext context) : base(context)
        {
        }

        public List<KullaniciDto> GetKullaniciDtos()
        {
            using(MhtContext db = new MhtContext())
            {
                var query = from k in db.Kullanicilar
                            where k.IsDeleted == false
                            select new KullaniciDto
                            {
                                Id = k.Id,
                                Isim = k.Isim,
                                Soyisim = k.Soyisim,
                                KullaniciAdi = k.KullaniciAdi,
                                Sifre = k.Sifre,
                                YoneticiMi = k.YoneticiMi
                            };
                return query.ToList();
            }
        }
    }
}
