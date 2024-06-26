﻿using MHT.DataAccess.Concrete.Contexts;
using MHT.Entity.DTOs;
using MHT.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zurafworks.Shared.Data.Abstract;

namespace MHT.DataAccess.Abstract
{
    public interface IMakineDal:IEntityRepository<Makine>
    {
        public List<MakineDto> GetMakineDtos();
    }
}
