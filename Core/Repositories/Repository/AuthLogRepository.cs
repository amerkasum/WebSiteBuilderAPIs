using Core.EF;
using Core.Repositories.IRepository;
using Domain.Entities.AppLogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.Repository
{
    public class AuthLogRepository : Repository<AuthLog>, IAuthLogRepository
    {
        public AuthLogRepository(LogsDbContext logsContext) : base(logsContext)
        {
        }
    }
}
