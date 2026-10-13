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
    public interface IMessageUsService
    {
        Task<IEnumerable<MessageUsDto>> GetAsync(MessageUsRequest model);
        Task<MessageUs> AddAsync(MessageUsViewModel model);
        Task<MessageUs> EditAsync(MessageUsViewModel model);
        Task DeleteAsync(int id);

    }
}
