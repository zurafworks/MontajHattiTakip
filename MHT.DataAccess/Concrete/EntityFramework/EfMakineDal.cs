using MHT.DataAccess.Abstract;
using MHT.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zurafworks.Shared.Data.Concrete.EntityFramework;

namespace MHT.DataAccess.Concrete.EntityFramework
{
    public class EfMakineDal : EfEntityRepositoryBase<Makine>, IMakineDal
    {
        public EfMakineDal(DbContext context) : base(context)
        {
        }
    }
}
