using Core.EF;
using Core.Repositories.IRepository;
using Domain.DTO;
using Domain.Entities.Logs;
using Domain.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.Repository
{
    public class AuthEventTypeRepository : Repository<AuthEventType>, IAuthEventTypeRepository
    {
        public AuthEventTypeRepository(LogsDbContext logsContext) : base(logsContext)
        {
        }

        public async Task<IEnumerable<AuthEventTypeDto>> GetAsync(AuthEventTypeRequest model)
        {
            var result = await _logsContext.AuthEventType.AsNoTracking()
                .Where(x => (!string.IsNullOrEmpty(model.Search) || (x.Name.Contains(model.Search) || x.Code.Contains(model.Search))))
                .Select(x => new AuthEventTypeDto 
                {
                    Id = x.Id,
                    Name = x.Name,
                    Code = x.Code,
                    Description = x.Description
                }).ToListAsync();

            return result;
        }
    }
}
