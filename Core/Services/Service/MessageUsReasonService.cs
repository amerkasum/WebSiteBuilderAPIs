using Core.Services.IService;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.System;
using Domain.Requests;
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

        public async Task<IEnumerable<BasicSearchResponse>> GetAsync(BasicSearchRequest model)
        {
            model.Search = model?.Search?.Trim();
            var result = await UnitOfWork.MessageUsReason.GetAsync(model);
            return result;
        }

        public async Task<MessageUsReason> AddAsync(MessageUsReasonViewModel model)
        {
            var messageUsReason = new MessageUsReason
            {
                Name = model.Name,
                Code = model.Code
            };

            UnitOfWork.MessageUsReason.Add(messageUsReason);
            await UnitOfWork.SaveChangesAsync();

            return messageUsReason;
        }

        public async Task<MessageUsReason> EditAsync(MessageUsReasonViewModel model)
        {
            var messageUsReason = await UnitOfWork.MessageUsReason.GetByIdAsync(model.Id);

            if (messageUsReason == null)
                throw new KeyNotFoundException();

            messageUsReason.Name = model.Name;
            messageUsReason.Code = model.Code;

            UnitOfWork.MessageUsReason.Update(messageUsReason);
            await UnitOfWork.SaveChangesAsync();

            return messageUsReason;
        }

        public async Task DeleteAsync(int id)
        {
            var messageUsReason = await UnitOfWork.MessageUsReason.GetByIdAsync(id);

            if (messageUsReason == null)
                throw new KeyNotFoundException();

            UnitOfWork.MessageUsReason.Remove(messageUsReason);
            await UnitOfWork.SaveChangesAsync();
        }

        
    }
}
