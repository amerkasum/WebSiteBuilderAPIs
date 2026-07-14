using Core.EF;
using Core.Repositories.IRepository;
using Domain.DTO;
using Domain.Entities.System;
using Microsoft.EntityFrameworkCore;
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

        public List<MessageUsDto> GetAllWithParameters(string senderEmail, int? messageUsReasonId, DateTime? dateFrom, DateTime? dateTo)
        {
            var messageUsReasons = _context.MessageUsReasons.ToList();

            var result = _context.MessageUs.Where(x => 
            (senderEmail == null || x.SenderEmail.ToLower() == senderEmail.ToLower())
            && (!messageUsReasonId.HasValue || x.MessageUsReasonId == messageUsReasonId.Value)
            && ((!dateFrom.HasValue || x.CreatedDateTime >= dateFrom.Value) && (!dateTo.HasValue || x.CreatedDateTime <= dateTo.Value))).Select(x => new MessageUsDto
            {
                Id = x.Id, 
                Message = x.Message,
                CreatedDateTime = x.CreatedDateTime,
                SenderEmail = x.SenderEmail,
                MessageUsReason = messageUsReasons.FirstOrDefault(m => m.Id == x.MessageUsReasonId).Name
            }).ToList();

            return result;
        }
    }
}
