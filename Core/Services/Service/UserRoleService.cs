using Core.Services.IService;
using Core.UnitOfWork;
using Domain.Entities.Personal;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Service
{
    public class UserRoleService : IUserRoleService
    {
        private readonly IUnitOfWork UnitOfWork;
        public UserRoleService(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }
        public UserRole Add(UserRoleViewModel model)
        {
            var userRole = new UserRole
            {
                UserId = model.UserId,
                RoleId = model.RoleId
            };

            UnitOfWork.UserRole.Add(userRole);
            UnitOfWork.SaveChanges();

            return userRole;
        }

        public UserRole Edit(UserRoleViewModel model)
        {
            var userRole = UnitOfWork.UserRole.GetById(model.Id);

            if (userRole == null)
                throw new KeyNotFoundException();

            userRole.UserId = model.UserId;
            userRole.RoleId = model.RoleId;

            UnitOfWork.UserRole.Update(userRole);
            UnitOfWork.SaveChanges();

            return userRole;
        }

        public void Delete(int id)
        {
            var userRole = UnitOfWork.UserRole.GetById(id);

            if (userRole == null)
                throw new KeyNotFoundException();

            UnitOfWork.UserRole.Remove(userRole);
            UnitOfWork.SaveChanges();
        }

        
    }
}
