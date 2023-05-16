﻿using MHT.Entity.DTOs;
using MHT.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHT.Business.Abstract
{
    public interface IKullanimService
    {
        public Task<Kullanim> GetAsync(int id);
        public Task<IList<KullanimDto>> GetAllAsync();
        public Task AddAsync(Kullanim kullanim);
        public Task UpdateAsync(Kullanim kullanim);
    }
}
