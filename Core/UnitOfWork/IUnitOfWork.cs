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
        //UsersRepository UsersRepository { get; }
        ICountryRepository Countries{ get; }
        IRegionRepository Regions { get; }
        IMessageUsRepository MessageUs { get; }
        ISocialMediaRepository SocialMedia { get; }

        int SaveChanges();
        Task CompleteAsync();
        void BeginTransaction();
        void Commit();
        void RollBack();
        void Dispose();
    }
}