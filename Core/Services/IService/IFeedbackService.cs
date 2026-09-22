using Domain.Entities.System;
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
        Feedback Add(FeedbackViewModel model);
        Feedback Edit(FeedbackViewModel model);
        void Delete(int id);
    }
}
