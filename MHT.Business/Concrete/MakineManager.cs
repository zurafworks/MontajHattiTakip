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
    public class MakineManager : IMakineService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MakineManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddAsync(Makine makine)
        {
            await _unitOfWork.Makinaler.AddAsync(makine);
            await _unitOfWork.SaveAsync();
        }

        public IList<MakineDto> GetAllAsync()
        {

            var list = _unitOfWork.Makinaler.GetMakineDtos();
            return list;
        }

        public async Task<Makine> GetAsync(int id)
        {
            return await _unitOfWork.Makinaler.GetAsync(m=>m.Id== id);
        }

        public async Task<int> GetByName(string makineAdi)
        {
            var makine = await _unitOfWork.Makinaler.GetAsync(x => x.MakineAdi == makineAdi);
            return makine.Id;
        }

        public async Task UpdateAsync(Makine makine)
        {
            _unitOfWork.Makinaler.UpdateWithStateAsync(makine);
            await _unitOfWork.SaveAsync();
        }
    }
}
