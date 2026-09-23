using Core.Services.IService;
using Core.UnitOfWork;
using Domain.DTO;
using Domain.Entities.Personal;
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
        public UserSocialMediaService(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }

        public UserSocialMedia Add(UserSocialMediaViewModel model)
        {
            var userSocialMedia = new UserSocialMedia
            {
                UserId = model.UserId,
                SocialMediaId = model.SocialMediaId,
                Link = model.Link
            };

            UnitOfWork.UserSocialMedia.Add(userSocialMedia);
            UnitOfWork.SaveChanges();

            return userSocialMedia;
        }

        public UserSocialMedia Edit(UserSocialMediaViewModel model)
        {
            var userSocialMedia = UnitOfWork.UserSocialMedia.GetById(model.Id);

            if (userSocialMedia == null)
                throw new KeyNotFoundException();

            userSocialMedia.UserId = model.UserId;
            userSocialMedia.SocialMediaId = model.SocialMediaId;
            userSocialMedia.Link = model.Link;

            UnitOfWork.UserSocialMedia.Update(userSocialMedia);
            UnitOfWork.SaveChanges();

            return userSocialMedia;
        }

        public void Delete(int id)
        {
            var userSocialMedia = UnitOfWork.UserSocialMedia.GetById(id);

            if (userSocialMedia == null)
                throw new KeyNotFoundException();

            UnitOfWork.UserSocialMedia.Remove(userSocialMedia);
            UnitOfWork.SaveChanges();
        }

        public List<UserSocialMediaDto> GetByUserId(int userId)
        {
            var userSocialMedia = UnitOfWork.UserSocialMedia.GetByUserId(userId);

            var userSocialMediaDto = userSocialMedia.Select(x => new UserSocialMediaDto
            {
                Id = x.Id,
                Username = x.User.Username,
                FullName =  $"{x.User.FirstName} {x.User.LastName}",
                SocialMediaName = x.SocialMedia.Name,
                SocialMediaColor = x.SocialMedia.Color,
                SocialMediaDisplayOrder = x.SocialMedia.DisplayOrder,
                SocialMediaIcon = x.SocialMedia.Icon
            }).ToList();

            return userSocialMediaDto;
        }

        public List<UserSocialMediaDto> GetAll()
        {
            var userSocialMedia = UnitOfWork.UserSocialMedia.GetAll();

            var userSocialMediaDto = userSocialMedia.Select(x => new UserSocialMediaDto
            {
                Id = x.Id,
                Username = x.User.Username,
                FullName = $"{x.User.FirstName} {x.User.LastName}",
                SocialMediaName = x.SocialMedia.Name,
                SocialMediaColor = x.SocialMedia.Color,
                SocialMediaDisplayOrder = x.SocialMedia.DisplayOrder,
                SocialMediaIcon = x.SocialMedia.Icon
            }).ToList();

            return userSocialMediaDto;
        }
    }
}
