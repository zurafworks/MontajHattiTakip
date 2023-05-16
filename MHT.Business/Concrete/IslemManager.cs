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
    public class IslemManager : IIslemService
    {
        private readonly IUnitOfWork _unitOfWork;

        public IslemManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddAsync(Islem islem)
        {
            await _unitOfWork.Islemler.AddAsync(islem);
            await _unitOfWork.SaveAsync();
        }

        public async Task<IList<IslemDto>> GetAllAsync()
        {
            var query = from i in _unitOfWork.Islemler.GetAllAsync(i => !i.IsDeleted).Result.ToList()
                        select new IslemDto
                        {
                            Id = i.Id,
                            IslemAdi = i.IslemAdi
                        };

            return query.ToList();
        }

        public async Task<Islem> GetAsync(int id)
        {
            return await _unitOfWork.Islemler.GetAsync(i=>i.Id == id);
        }

        public async Task UpdateAsync(Islem islem)
        {
            await _unitOfWork.Islemler.UpdateAsync(islem);
            await _unitOfWork.SaveAsync();
        }
    }
}
