using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.IService
{
    public interface IAuthLogService
    {
        Task Logger(string email, int authEventTypeId, bool isSuccessful, string? failureReason);
    }
}
