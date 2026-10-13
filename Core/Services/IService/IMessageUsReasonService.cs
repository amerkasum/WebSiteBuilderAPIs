using Domain.DTO;
using Domain.Entities.System;
using Domain.Requests;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.IService
{
    public interface IMessageUsReasonService
    {
        Task<IEnumerable<BasicSearchResponse>> GetAsync(BasicSearchRequest model);
        Task<MessageUsReason> AddAsync(MessageUsReasonViewModel model);
        Task<MessageUsReason> EditAsync(MessageUsReasonViewModel model);
        Task DeleteAsync(int id);
    }
}
