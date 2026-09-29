using Core.EF;
using Core.Repositories.IRepository;
using Domain.DTO;
using Domain.Entities.System;
using Domain.Requests;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Core.Repositories.Repository
{
    public class FeedbackRepository : Repository<Feedback>, IFeedbackRepository
    {
        public FeedbackRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IEnumerable<FeedbackDto> GetByUserId(int userId)
        {
            var feebacks = _context.Feedback.Where(x => x.UserId == userId).Select(x => new FeedbackDto
            {
                Id = x.Id,
                UserId = x.UserId,
                Message = x.Message, 
                Rating = x.Rating

            }).AsEnumerable();

            return feebacks;
        }

        public IEnumerable<FeedbackDto> Get(BasicSearchRequest model)
        {
            return _context.Feedback.Include(x => x.User).Where(x => !x.IsDeleted 
                            && (string.IsNullOrEmpty(model.Search) || (x.Message.Contains(model.Search) || x.User.FirstName.Contains(model.Search) || x.User.LastName.Contains(model.Search)))).Select(x => new FeedbackDto
            {
                Id = x.Id,
                UserId = x.UserId,
                FullName = $"{x.User.FirstName} {x.User.LastName}",
                Message = x.Message,
                Rating = x.Rating
            }).AsEnumerable();
        }
    }
}
