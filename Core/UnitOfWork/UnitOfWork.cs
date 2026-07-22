using Core.EF;
using Core.Repositories.IRepository;
using Core.Repositories.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _context;

        public ICountryRepository Countries => new CountryRepository(_context);
        public IRegionRepository Regions => new RegionRepository(_context);
        public IMessageUsRepository MessageUs => new MessageUsRepository(_context);
        public ISocialMediaRepository SocialMedia => new SocialMediaRepository(_context);
        public UnitOfWork(ApplicationDbContext context)
        {
            this._context = context;
        }

        //begin, commit, rollback ----> implementirati

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing) _context.Dispose();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void BeginTransaction()
        {
            _context.Database.BeginTransaction();
        }

        public void Commit()
        {
            _context.Database.CommitTransaction();
        }

        public void RollBack()
        {
            _context.Database.RollbackTransaction();
            _context.Dispose();
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
