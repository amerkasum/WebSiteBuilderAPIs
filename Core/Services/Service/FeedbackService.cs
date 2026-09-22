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
    public class FeedbackService : IFeedbackService
    {
        private readonly IUnitOfWork UnitOfWork;
        public FeedbackService(IUnitOfWork unitOfwork)
        {
            this.UnitOfWork = unitOfwork;
        }

        public Feedback Add(FeedbackViewModel model)
        {
            var feedback = new Feedback
            {
                UserId = model.UserId,
                Message = model.Message,
                Rating = model.Rating
            };

            UnitOfWork.Feedback.Add(feedback);
            UnitOfWork.SaveChanges();

            return feedback;
        }

        public Feedback Edit(FeedbackViewModel model)
        {
            var feedback = UnitOfWork.Feedback.GetById(model.Id);

            if (feedback == null)
                throw new KeyNotFoundException();

            feedback.Message = model.Message;
            feedback.Rating = model.Rating;

            UnitOfWork.Feedback.Update(feedback);
            UnitOfWork.SaveChanges();

            return feedback;
        }

        public void Delete(int id)
        {
            var feedback = UnitOfWork.Feedback.GetById(id);

            if (feedback == null)
                throw new KeyNotFoundException();

            UnitOfWork.Feedback.Remove(feedback);
            UnitOfWork.SaveChanges();
        }

        
    }
}
