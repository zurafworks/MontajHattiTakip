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
    public class KullanimManager : IKullanimService
    {
        private readonly IUnitOfWork _unitofwork;
        public KullanimManager(IUnitOfWork unitOfWork)
        {
            _unitofwork = unitOfWork;
        }

        public async Task AddAsync(Kullanim kullanim)
        {
            await _unitofwork.Kullanimlar.AddAsync(kullanim);
            await _unitofwork.SaveAsync();
        }

        public async Task<IList<KullanimDto>> GetAllAsync()
        {
            return _unitofwork.Kullanimlar.GetAllKullanimDto();
        }

        public async Task<Kullanim> GetAsync(int id)
        {
            return await _unitofwork.Kullanimlar.GetAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(Kullanim kullanim)
        {
            await _unitofwork.Kullanimlar.UpdateAsync(kullanim);
            await _unitofwork.SaveAsync();
        }
    }
}
