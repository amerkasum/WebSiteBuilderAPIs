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

        #region Repositories
        public ICountryRepository Countries => new CountryRepository(_context);
        public IRegionRepository Regions => new RegionRepository(_context);
        public IMessageUsRepository MessageUs => new MessageUsRepository(_context);
        public ISocialMediaRepository SocialMedia => new SocialMediaRepository(_context);
        public ISettingsRepository Settings => new SettingsRepository(_context);
        public IUserContactRepository UserContact => new UserContactRepository(_context);
        public IUserSocialMediaRepository UserSocialMedia => new UserSocialMediaRepository(_context);
        public IRoleRepository Role => new RoleRepository(_context);
        public IUserRoleRepository UserRole => new UserRoleRepository(_context);
        public IUserRepository User => new UserRepository(_context);
        public ICityRepository City => new CityRepository(_context);
        public IAddressRepository Address => new AddressRepository(_context);
        public IGenderRepository Gender => new GenderRepository(_context);
        public IUserActivityRepository UserActivity => new UserActivityRepository(_context);
        public IContactTypeRepository ContactType => new ContactTypeRepository(_context);
        public IBusinessTypeRepository BusinessType => new BusinessTypeRepository(_context);
        public IMessageUsReasonRepository MessageUsReason => new MessageUsReasonRepository(_context);
        public IFeedbackRepository Feedback => new FeedbackRepository(_context);
        public IComponentTypeRepository ComponentType => new ComponentTypeRepository(_context);
        public IUserResidenceRepository UserResidence => new UserResidenceRepository(_context);

        #endregion
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
