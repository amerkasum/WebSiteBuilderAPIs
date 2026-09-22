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
    public class SocialMediaService : ISocialMediaService
    {
        private readonly IUnitOfWork UnitOfWork;
        public SocialMediaService(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }
        public SocialMedia Add(SocialMediaViewModel model)
        {
            var socialMedia = new SocialMedia
            {
                Name = model.Name,
                Code = model.Code,
                Icon = model.Icon,
                Color = model.Color,
            };

            var highestDisplayOrder = UnitOfWork.SocialMedia.GetHighestDisplayOrder();
            socialMedia.DisplayOrder = highestDisplayOrder + 1;

            UnitOfWork.SocialMedia.Add(socialMedia);
            UnitOfWork.SaveChanges();

            return socialMedia;
        }

        public SocialMedia Edit(SocialMediaViewModel model)
        {
            var socialMedia = UnitOfWork.SocialMedia.GetById(model.Id);

            if (socialMedia == null)
                throw new KeyNotFoundException();

            socialMedia.Name = model.Name;
            socialMedia.Code = model.Code;
            socialMedia.Color = model.Color;
            socialMedia.Icon = model.Icon;
            socialMedia.DisplayOrder = model.DisplayOrder;

            UnitOfWork.SocialMedia.Update(socialMedia);
            UnitOfWork.SaveChanges();

            return socialMedia;
        }

        public void Delete(int id)
        {
            var socialMedia = UnitOfWork.SocialMedia.GetById(id);

            if (socialMedia == null)
                throw new KeyNotFoundException();

            UnitOfWork.SocialMedia.Remove(socialMedia);
            UnitOfWork.SaveChanges();
        }
    }
}
