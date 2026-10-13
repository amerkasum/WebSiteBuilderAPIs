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
        Task<UserResidence> AddAsync(UserResidenceViewModel model);
        Task<UserResidence> EditAsync(UserResidenceViewModel model);
        Task DeleteAsync(int id);
    }
}
