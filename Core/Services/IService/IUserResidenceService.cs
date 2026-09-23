using Domain.Entities.Personal;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.IService
{
    public interface IUserResidenceService
    {
        UserResidence Add(UserResidenceViewModel model);
        UserResidence Edit(UserResidenceViewModel model);
        void Delete(int id);
    }
}
