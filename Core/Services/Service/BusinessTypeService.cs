using Core.Services.IService;
using Core.UnitOfWork;
using Domain.Entities.WebSiteBuilder;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Service
{
    public class BusinessTypeService :IBusinessTypeService
    {
        private readonly IUnitOfWork UnitOfWork;
        public BusinessTypeService(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }

        public BusinessType Add(BusinessTypeViewModel model)
        {
            var businessType = new BusinessType
            {
                Name = model.Name,
                Code = model.Code
            };

            UnitOfWork.BusinessType.Add(businessType);
            UnitOfWork.SaveChanges();

            return businessType;
        }

        public BusinessType Edit(BusinessTypeViewModel model)
        {
            var businessType = UnitOfWork.BusinessType.GetById(model.Id);

            if (businessType == null)
                throw new KeyNotFoundException();

            businessType.Name = model.Name;
            businessType.Code = model.Code;

            UnitOfWork.BusinessType.Update(businessType);
            UnitOfWork.SaveChanges();

            return businessType;

        }

        public void Delete(int id)
        {
            var businessType = UnitOfWork.BusinessType.GetById(id);

            if (businessType == null)
                throw new KeyNotFoundException();

            UnitOfWork.BusinessType.Remove(businessType);
            UnitOfWork.SaveChanges();
        }

        
    }
}
