using Core.Services.IService;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.System;
using Domain.Requests;
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

        public IEnumerable<BasicSearchResponse> Get(BasicSearchRequest model)
        {
            model.Search = model?.Search?.Trim();
            var result = UnitOfWork.Role.Get(model);
            return result;
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
