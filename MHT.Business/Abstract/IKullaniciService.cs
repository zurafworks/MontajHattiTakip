using MHT.Entity.DTOs;
using MHT.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHT.Business.Abstract
{
    public interface IKullaniciService
    {
        public Task<Kullanici> GetAsync(int id);
        public Task<IList<KullaniciDto>> GetAllAsync();
        public Task AddAsync(Kullanici kullanici);
        public Task UpdateAsync(Kullanici kullanici);
        public Task<Kullanici> CheckPassword(string userName, string password);
    }
}
