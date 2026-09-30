using Domain.DTO;
using Domain.Entities.Personal;
using Domain.Entities.System;
using Domain.Requests;
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
        IEnumerable<UserSocialMediaDto> Get(UserSocialMediaRequest model);
        UserSocialMedia Add(UserSocialMediaViewModel model);
        UserSocialMedia Edit(UserSocialMediaViewModel model);
        void Delete(int id);
    }
}
