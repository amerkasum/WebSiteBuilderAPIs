using Domain.DTO;
using Domain.Entities.Logs;
using Domain.Requests;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.IService
{
    public interface IAuthEventTypeService
    {
        Task<IEnumerable<AuthEventTypeDto>> GetAsync(AuthEventTypeRequest model);
        Task<AuthEventType> AddAsync(AuthEventTypeViewModel model);
        Task<AuthEventType> EditAsync(AuthEventTypeViewModel model);
        Task DeleteAsync(int id);
    }
}
