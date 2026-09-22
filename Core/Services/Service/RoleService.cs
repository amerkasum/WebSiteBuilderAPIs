using Core.Services.IService;
using Core.UnitOfWork;
using Domain.Entities.System;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Service
{
    public class RoleService : IRoleService
    {
        private readonly IUnitOfWork UnitOfWork;
        public RoleService(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }

        public Role Add(RoleViewModel model)
        {
            var role = new Role
            {
                Name = model.Code,
                Code = model.Code
            };

            UnitOfWork.Role.Add(role);
            UnitOfWork.SaveChanges();

            return role;
        }

        public Role Edit(RoleViewModel model)
        {
            var role = UnitOfWork.Role.GetById(model.Id);

            if (role == null)
                throw new KeyNotFoundException();

            role.Name = model.Name;
            role.Code = model.Code;

            UnitOfWork.Role.Update(role);
            UnitOfWork.SaveChanges();

            return role;
        }

        public void Delete(int id)
        {
            var role = UnitOfWork.Role.GetById(id);

            if (role == null)
                throw new KeyNotFoundException();

            UnitOfWork.Role.Remove(role);
            UnitOfWork.SaveChanges();
        }
    }
}
