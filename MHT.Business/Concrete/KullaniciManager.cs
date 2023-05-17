using MHT.Business.Abstract;
using MHT.DataAccess.Abstract;
using MHT.Entity.DTOs;
using MHT.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHT.Business.Concrete
{
    public class KullaniciManager : IKullaniciService
    {
        private readonly IUnitOfWork _unitOfWork;

        public KullaniciManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddAsync(Kullanici kullanici)
        {
            await _unitOfWork.Kullanicilar.AddAsync(kullanici);
            await _unitOfWork.SaveAsync();
        }

        public async Task<Kullanici> CheckPassword(string userName, string password)
        {
            var kullanici = await _unitOfWork.Kullanicilar.GetAsync(u => u.KullaniciAdi == userName && u.IsDeleted== false);
            if (kullanici != null || kullanici.Sifre == password)
            {
                var girisYapan = new Kullanici();
                girisYapan.Isim = kullanici.Isim;
                girisYapan.Soyisim = kullanici.Soyisim;
                girisYapan.Id = kullanici.Id;
                girisYapan.YoneticiMi = kullanici.YoneticiMi;
                return girisYapan;
            }
            return null;

        }

        public IList<KullaniciDto> GetAllAsync()
        {
            //var list = _unitOfWork.Kullanicilar.GetAllAsync(k => !k.IsDeleted).Result.ToList();
            //var query = from k in list
            //            select new KullaniciDto
            //            {
            //                Id = k.Id,
            //                Isim = k.Isim,
            //                KullaniciAdi = k.KullaniciAdi,
            //                Sifre = k.Sifre,
            //                Soyisim = k.Soyisim,
            //                YoneticiMi = k.YoneticiMi,
            //            };
            //return  query.ToList();

            var list = _unitOfWork.Kullanicilar.GetKullaniciDtos();
            return list;
        }

        public async Task<Kullanici> GetAsync(int id)
        {
            return await _unitOfWork.Kullanicilar.GetAsync(k=>k.Id == id);
        }

        public async Task UpdateAsync(Kullanici kullanici)
        {

            _unitOfWork.Kullanicilar.UpdateWithStateAsync(kullanici);
            await _unitOfWork.SaveAsync();
        }
    }
}
