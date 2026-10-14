using Domain.Entities.AppLogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.IRepository
{
    public interface IAuthLogRepository : IRepository<AuthLog>
    {
    }
}
