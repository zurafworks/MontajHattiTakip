using MHT.Entity.DTOs;
using MHT.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHT.Business.Abstract
{
    public interface IVardiyaService
    {
        public Task<Vardiya> GetAsync(int id);
        public Task<IList<VardiyaDto>> GetAllAsync();
        public Task AddAsync(Vardiya vardiya);
        public Task UpdateAsync(Vardiya vardiya);
        public Task<Vardiya> CheckActive(int userId, int islemId);
    }
}
