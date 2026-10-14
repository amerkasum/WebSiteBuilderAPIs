using Core.EF;
using Core.Services.IService;
using Core.UnitOfWork;
using Domain.Entities.AppLogs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Service
{
    public class AuthLogService : IAuthLogService
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly IHttpContextAccessor HttpContextAccessor;

        public AuthLogService(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
            this.UnitOfWork = unitOfWork;
            this.HttpContextAccessor = httpContextAccessor;
        }

        public async Task Logger(string email, int authEventTypeId, bool isSuccessful, string? failureReason)
        {
            var context = HttpContextAccessor.HttpContext;
            var request = context?.Request;

            var authLog = new AuthLog
            {
                AuthEventTypeId = authEventTypeId,
                Email = email,
                IpAddress = context?.Connection?.RemoteIpAddress?.ToString(),
                BrowserInfo = request?.Headers?.UserAgent.ToString(),
                IsSuccessful = isSuccessful,
                FailureReason = failureReason,
            };

            UnitOfWork.AuthLog.Add(authLog);
            await UnitOfWork.SaveChangesAsync();
        }
    }
}
