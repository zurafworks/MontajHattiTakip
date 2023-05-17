using MHT.Entity.DTOs;
using MHT.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHT.Business.Abstract
{
    public interface IMakineService
    {
        public Task<Makine> GetAsync(int id);
        public IList<MakineDto> GetAllAsync();
        public Task AddAsync(Makine makine);
        public Task UpdateAsync(Makine makine);
        public Task<int> GetByName(string makineAdi);
    }
}
