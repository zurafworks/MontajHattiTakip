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

        public async Task<IList<KullaniciDto>> GetAllAsync()
        {
            var query = from k in _unitOfWork.Kullanicilar.GetAllAsync(k => !k.IsDeleted).Result
                        select new KullaniciDto
                        {
                            Id = k.Id,
                            Isim = k.Isim,
                            KullaniciAdi = k.KullaniciAdi,
                            Sifre = k.Sifre,
                            Soyisim = k.Soyisim,
                            YoneticiMi = k.YoneticiMi,
                        };
            return  query.ToList();

        }

        public async Task<Kullanici> GetAsync(int id)
        {
            return await _unitOfWork.Kullanicilar.GetAsync(k=>k.Id == id);
        }

        public async Task UpdateAsync(Kullanici kullanici)
        {
            await _unitOfWork.Kullanicilar.UpdateAsync(kullanici);
            await _unitOfWork.SaveAsync();
        }
    }
}
