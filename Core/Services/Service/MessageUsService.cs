using Core.Services.IService;
using Core.UnitOfWork;
using Domain.Entities.System;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Service
{
    public class MessageUsService : IMessageUsService
    {
        private readonly IUnitOfWork UnitOfWork;
        public MessageUsService(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }
        public MessageUs Add(MessageUsViewModel model)
        {
            var messageUs = new MessageUs
            {
                Message = model.Message,
                EmailSender = model.EmailSender,
                MessageUsReasonId = model.MessageUsReasonId
            };

            UnitOfWork.MessageUs.Add(messageUs);
            UnitOfWork.SaveChanges();

            return messageUs;
        }

        public MessageUs Edit(MessageUsViewModel model)
        {
            var messageUs = UnitOfWork.MessageUs.GetById(model.Id);

            if (messageUs == null)
                throw new KeyNotFoundException();

            messageUs.Message = model.Message;
            messageUs.MessageUsReasonId = model.MessageUsReasonId;

            UnitOfWork.MessageUs.Update(messageUs);
            UnitOfWork.SaveChanges();

            return messageUs;
        }

        public void Delete(int id)
        {
            var messageUs = UnitOfWork.MessageUs.GetById(id);

            if (messageUs == null)
                throw new KeyNotFoundException();

            UnitOfWork.MessageUs.Remove(messageUs);
            UnitOfWork.SaveChanges();
        }
    }
}
