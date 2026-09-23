using Domain.DTO;
using Domain.Entities.Personal;
using Domain.Entities.System;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.IService
{
    public interface IUserSocialMediaService
    {
        List<UserSocialMediaDto> GetByUserId(int userId);
        List<UserSocialMediaDto> GetAll();
        UserSocialMedia Add(UserSocialMediaViewModel model);
        UserSocialMedia Edit(UserSocialMediaViewModel model);
        void Delete(int id);
    }
}
