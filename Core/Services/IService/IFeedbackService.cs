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
        IEnumerable<FeedbackDto> Get(BasicSearchRequest model);
        Feedback Add(FeedbackViewModel model);
        Feedback Edit(FeedbackViewModel model);
        void Delete(int id);
    }
}
