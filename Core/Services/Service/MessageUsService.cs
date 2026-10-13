using Core.Services.IService;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.System;
using Domain.Requests;
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
        public async Task<MessageUs> AddAsync(MessageUsViewModel model)
        {
            var messageUs = new MessageUs
            {
                Message = model.Message,
                EmailSender = model.EmailSender,
                MessageUsReasonId = model.MessageUsReasonId
            };

            UnitOfWork.MessageUs.Add(messageUs);
            await UnitOfWork.SaveChangesAsync();

            return messageUs;
        }

        public async Task<MessageUs> EditAsync(MessageUsViewModel model)
        {
            var messageUs = await UnitOfWork.MessageUs.GetByIdAsync(model.Id);

            if (messageUs == null)
                throw new KeyNotFoundException();

            messageUs.Message = model.Message;
            messageUs.MessageUsReasonId = model.MessageUsReasonId;

            UnitOfWork.MessageUs.Update(messageUs);
            await UnitOfWork.SaveChangesAsync();

            return messageUs;
        }

        public async Task DeleteAsync(int id)
        {
            var messageUs = await UnitOfWork.MessageUs.GetByIdAsync(id);

            if (messageUs == null)
                throw new KeyNotFoundException();

            UnitOfWork.MessageUs.Remove(messageUs);
            await UnitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<MessageUsDto>> GetAsync(MessageUsRequest model)
        {
            return await UnitOfWork.MessageUs.GetAsync(model);
        }
    }
}
