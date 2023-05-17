﻿using MHT.Entity.DTOs;
using MHT.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zurafworks.Shared.Data.Abstract;

namespace MHT.DataAccess.Abstract
{
    public interface IKullaniciDal:IEntityRepository<Kullanici>
    {
        public List<KullaniciDto> GetKullaniciDtos(); 
    }
}
