using Core.Services.IService;
using Core.UnitOfWork;
using Domain.Entities.System;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Service
{
    public class MessageUsReasonService : IMessageUsReasonService
    {
        private readonly IUnitOfWork UnitOfWork;
        public MessageUsReasonService(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }
        public MessageUsReason Add(MessageUsReasonViewModel model)
        {
            var messageUsReason = new MessageUsReason
            {
                Name = model.Name,
                Code = model.Code
            };

            UnitOfWork.MessageUsReason.Add(messageUsReason);
            UnitOfWork.SaveChanges();

            return messageUsReason;
        }

        public MessageUsReason Edit(MessageUsReasonViewModel model)
        {
            var messageUsReason = UnitOfWork.MessageUsReason.GetById(model.Id);

            if (messageUsReason == null)
                throw new KeyNotFoundException();

            messageUsReason.Name = model.Name;
            messageUsReason.Code = model.Code;

            UnitOfWork.MessageUsReason.Update(messageUsReason);
            UnitOfWork.SaveChanges();

            return messageUsReason;
        }

        public void Delete(int id)
        {
            var messageUsReason = UnitOfWork.MessageUsReason.GetById(id);

            if (messageUsReason == null)
                throw new KeyNotFoundException();

            UnitOfWork.MessageUsReason.Remove(messageUsReason);
            UnitOfWork.SaveChanges();
        }

        
    }
}
