using MHT.DataAccess.Abstract;
using MHT.DataAccess.Concrete.Contexts;
using MHT.DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHT.DataAccess.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MhtContext _context;
        public UnitOfWork(DbContext db)
        {
            _context = (MhtContext)db;
        }

        private EfIslemDal _islemDal;
        public IIslemDal Islemler => _islemDal ?? new EfIslemDal(_context);

        private EfKullaniciDal _kullaniciDal;
        public IKullaniciDal Kullanicilar => _kullaniciDal ?? new EfKullaniciDal(_context);

        private EfKullanimDal _kullanimDal;
        public IKullanimDal Kullanimlar => _kullanimDal ?? new EfKullanimDal(_context);

        private EfMakineDal _makineDal;
        public IMakineDal Makinaler => _makineDal ?? new EfMakineDal(_context);

        private EfVardiyaDal _vardiyaDal;
        public IVardiyaDal Vardiyalar => _vardiyaDal ?? new EfVardiyaDal(_context);

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
