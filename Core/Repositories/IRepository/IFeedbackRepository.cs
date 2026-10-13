using Domain.DTO;
using Domain.Entities.System;
using Domain.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.IRepository
{
    public interface IFeedbackRepository : IRepository<Feedback>
    {
        Task<IEnumerable<FeedbackDto>> GetAsync(BasicSearchRequest model);
        IEnumerable<FeedbackDto> GetByUserId(int userId);
    }
}
