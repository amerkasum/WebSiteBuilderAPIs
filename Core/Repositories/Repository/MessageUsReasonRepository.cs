using Core.EF;
using Core.Repositories.IRepository;
using Domain.Entities.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.Repository
{
    public class MessageUsReasonRepository : Repository<MessageUsReason>, IMessageUsReasonRepository
    {
        public MessageUsReasonRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
