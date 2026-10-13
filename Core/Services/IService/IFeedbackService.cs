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
    public interface IFeedbackService
    {
        Task<IEnumerable<FeedbackDto>> GetAsync(BasicSearchRequest model);
        Task<Feedback> AddAsync(FeedbackViewModel model);
        Task<Feedback> EditAsync(FeedbackViewModel model);
        Task DeleteAsync(int id);
    }
}
