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
    public class SocialMediaService : ISocialMediaService
    {
        private readonly IUnitOfWork UnitOfWork;
        public SocialMediaService(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<BasicSearchResponse>> GetAsync(BasicSearchRequest model)
        {
            model.Search = model?.Search?.Trim();
            var result =  await UnitOfWork.SocialMedia.GetAsync(model);
            return result;
        }

        public async Task<SocialMedia> AddAsync(SocialMediaViewModel model)
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
            await UnitOfWork.SaveChangesAsync();

            return socialMedia;
        }

        public async Task<SocialMedia> EditAsync(SocialMediaViewModel model)
        {
            var socialMedia = await UnitOfWork.SocialMedia.GetByIdAsync(model.Id);

            if (socialMedia == null)
                throw new KeyNotFoundException();

            socialMedia.Name = model.Name;
            socialMedia.Code = model.Code;
            socialMedia.Color = model.Color;
            socialMedia.Icon = model.Icon;
            socialMedia.DisplayOrder = model.DisplayOrder;

            UnitOfWork.SocialMedia.Update(socialMedia);
            await UnitOfWork.SaveChangesAsync();

            return socialMedia;
        }

        public async Task DeleteAsync(int id)
        {
            var socialMedia = await UnitOfWork.SocialMedia.GetByIdAsync(id);

            if (socialMedia == null)
                throw new KeyNotFoundException();

            UnitOfWork.SocialMedia.Remove(socialMedia);
            await UnitOfWork.SaveChangesAsync();
        }
    }
}
