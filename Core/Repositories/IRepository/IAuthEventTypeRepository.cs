using Domain.DTO;
using Domain.Entities.Logs;
using Domain.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.IRepository
{
    public interface IAuthEventTypeRepository : IRepository<AuthEventType>
    {
        Task<IEnumerable<AuthEventTypeDto>> GetAsync(AuthEventTypeRequest model);
    }
}
