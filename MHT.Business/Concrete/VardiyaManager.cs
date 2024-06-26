﻿using MHT.Business.Abstract;
using MHT.DataAccess.Abstract;
using MHT.Entity.DTOs;
using MHT.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHT.Business.Concrete
{
    public class VardiyaManager : IVardiyaService
    {
        private readonly IUnitOfWork _unitOfWork;

        public VardiyaManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddAsync(Vardiya vardiya)
        {
            await _unitOfWork.Vardiyalar.AddAsync(vardiya);
            await _unitOfWork.SaveAsync();
        }

        public async Task<Vardiya> CheckActive(int userId, int islemId)
        {
            var vardiya = await _unitOfWork.Vardiyalar.GetAsync(x => x.KullaniciId == userId && x.IslemId == islemId && x.IsActive == true);
            if (vardiya != null )
            {
                return vardiya;
            }
            return null;
        }

        public async Task<IList<VardiyaDto>> GetAllAsync()
        {
            var vardiyalar = _unitOfWork.Vardiyalar.GetAllVardiyaDto();
            return vardiyalar;
        }

        public async Task<Vardiya> GetAsync(int id)
        {
            return await _unitOfWork.Vardiyalar.GetAsync(v=>v.Id== id);
        }

        public async Task UpdateAsync(Vardiya vardiya)
        {
            await _unitOfWork.Vardiyalar.UpdateAsync(vardiya);
            await _unitOfWork.SaveAsync();
        }
    }
}
