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
    public class FeedbackService : IFeedbackService
    {
        private readonly IUnitOfWork UnitOfWork;
        public FeedbackService(IUnitOfWork unitOfwork)
        {
            this.UnitOfWork = unitOfwork;
        }

        public async Task<IEnumerable<FeedbackDto>> GetAsync(BasicSearchRequest model)
        {
            model.Search = model?.Search?.Trim();
            return  await UnitOfWork.Feedback.GetAsync(model);
        }

        public async Task<Feedback> AddAsync(FeedbackViewModel model)
        {
            var feedback = new Feedback
            {
                UserId = model.UserId,
                Message = model.Message,
                Rating = model.Rating
            };

            UnitOfWork.Feedback.Add(feedback);
            await UnitOfWork.SaveChangesAsync();

            return feedback;
        }

        public async Task<Feedback> EditAsync(FeedbackViewModel model)
        {
            var feedback = await UnitOfWork.Feedback.GetByIdAsync(model.Id);

            if (feedback == null)
                throw new KeyNotFoundException();

            feedback.Message = model.Message;
            feedback.Rating = model.Rating;

            UnitOfWork.Feedback.Update(feedback);
            await UnitOfWork.SaveChangesAsync();

            return feedback;
        }

        public async Task DeleteAsync(int id)
        {
            var feedback = await UnitOfWork.Feedback.GetByIdAsync(id);

            if (feedback == null)
                throw new KeyNotFoundException();

            UnitOfWork.Feedback.Remove(feedback);
            await UnitOfWork.SaveChangesAsync();
        }
    }
}
