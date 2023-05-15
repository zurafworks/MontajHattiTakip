using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHT.DataAccess.Abstract
{
    public interface IUnitOfWork
    {
        IIslemDal Islemler { get; }
        IKullaniciDal Kullanicilar { get; }
        IKullanimDal Kullanimlar { get; }
        IMakineDal Makinaler { get; }
        IVardiyaDal Vardiyalar { get; }
        Task<int> SaveAsync();
    }
}
