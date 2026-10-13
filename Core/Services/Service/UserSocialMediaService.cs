using Core.Services.IService;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.Personal;
using Domain.Requests;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Service
{
    public class UserSocialMediaService : IUserSocialMediaService
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly IAuditLogService AuditLogService;
        public UserSocialMediaService(IUnitOfWork unitOfWork, IAuditLogService auditLogService)
        {
            this.UnitOfWork = unitOfWork;
            this.AuditLogService = auditLogService;
        }

        public async Task<IEnumerable<UserSocialMediaDto>> GetAsync(UserSocialMediaRequest model)
        {
            model.Search = model.Search?.Trim();
            return await UnitOfWork.UserSocialMedia.GetAsync(model);
        }

        public async Task<UserSocialMedia> AddAsync(UserSocialMediaViewModel model)
        {
            var userSocialMedia = new UserSocialMedia
            {
                UserId = model.UserId,
                SocialMediaId = model.SocialMediaId,
                Link = model.Link
            };

            UnitOfWork.UserSocialMedia.Add(userSocialMedia);
            await UnitOfWork.SaveChangesAsync();

            return userSocialMedia;
        }

        public async Task<UserSocialMedia> EditAsync(UserSocialMediaViewModel model)
        {
            var userSocialMedia = await UnitOfWork.UserSocialMedia.GetByIdAsync(model.Id);

            if (userSocialMedia == null)
                throw new KeyNotFoundException();

            userSocialMedia.UserId = model.UserId;
            userSocialMedia.SocialMediaId = model.SocialMediaId;
            userSocialMedia.Link = model.Link;

            UnitOfWork.UserSocialMedia.Update(userSocialMedia);
            await AuditLogService.Logger();
            await UnitOfWork.SaveChangesAsync();

            return userSocialMedia;
        }

        public async Task DeleteAsync(int id)
        {
            var userSocialMedia = await UnitOfWork.UserSocialMedia.GetByIdAsync(id);

            if (userSocialMedia == null)
                throw new KeyNotFoundException();

            UnitOfWork.UserSocialMedia.Remove(userSocialMedia);
            await AuditLogService.Logger();
            await UnitOfWork.SaveChangesAsync();
        }

    }
}
