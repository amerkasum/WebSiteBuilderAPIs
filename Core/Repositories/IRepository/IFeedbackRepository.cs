using Domain.DTO;
using Domain.Entities.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.IRepository
{
    public interface IFeedbackRepository : IRepository<Feedback>
    {
        IEnumerable<FeedbackDto> GetAll();
        IEnumerable<FeedbackDto> GetByUserId(int userId);
    }
}
