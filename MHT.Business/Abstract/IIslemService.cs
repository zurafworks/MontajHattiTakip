using MHT.Entity.DTOs;
using MHT.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHT.Business.Abstract
{
    public interface IIslemService
    {
        public Task<Islem> GetAsync(int id);
        public Task<IList<IslemDto>> GetAllAsync();
        public Task AddAsync(Islem islem);
        public Task UpdateAsync(Islem islem);
    }
}
