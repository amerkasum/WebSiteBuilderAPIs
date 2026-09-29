using Core.EF;
using Core.Repositories.IRepository;
using Domain.DTO;
using Domain.Entities.System;
using Domain.Requests;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.Repository
{
    public class MessageUsRepository : Repository<MessageUs>, IMessageUsRepository
    {
        public MessageUsRepository(ApplicationDbContext context) : base(context)
        {
            
        }

        public List<MessageUsDto> Get(MessageUsRequest model)
        {
            var result = _context.MessageUs.Include(x => x.MessageUsReason).Where(x => 
            (string.IsNullOrWhiteSpace(model.Email) || x.EmailSender.ToLower() == model.Email.ToLower())
            && (!model.MessageUsReasonId.HasValue || x.MessageUsReasonId == model.MessageUsReasonId.Value)
            && ((!model.DateFrom.HasValue || x.CreatedDateTime >= model.DateFrom.Value) && (!model.DateTo.HasValue || x.CreatedDateTime <= model.DateTo.Value))).Select(x => new MessageUsDto
            {
                Id = x.Id, 
                Message = x.Message,
                CreatedDateTime = x.CreatedDateTime,
                SenderEmail = x.EmailSender,
                MessageUsReason = x.MessageUsReason.Name,
                MessageUsReasonId = x.MessageUsReasonId

            }).ToList();

            return result;
        }
    }
}
