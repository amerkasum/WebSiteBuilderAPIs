using Core.Repositories.IRepository;
using Core.Repositories.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.UnitOfWork
{
    public interface IUnitOfWork
    {
        #region Repositories
        ICountryRepository Countries { get; }
        IRegionRepository Regions { get; }
        IMessageUsRepository MessageUs { get; }
        ISocialMediaRepository SocialMedia { get; }
        ISettingsRepository Settings { get; }
        IUserSocialMediaRepository UserSocialMedia { get; }
        IUserContactRepository UserContact { get; }
        IRoleRepository Role { get; }
        IUserRoleRepository UserRole { get; }
        IUserRepository User { get; }
        ICityRepository City { get; }
        IAddressRepository Address { get; }
        IGenderRepository Gender { get; }
        IUserActivityRepository UserActivity { get; }
        IContactTypeRepository ContactType { get; }
        IBusinessTypeRepository BusinessType { get; }
        IMessageUsReasonRepository MessageUsReason { get; }
        IFeedbackRepository Feedback { get; }
        IComponentTypeRepository ComponentType { get; }
        IUserResidenceRepository UserResidence { get; }
        #endregion

        int SaveChanges();
        Task CompleteAsync();
        void BeginTransaction();
        void Commit();
        void RollBack();
        void Dispose();
    }
}