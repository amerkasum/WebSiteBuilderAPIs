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
        Task<IEnumerable<UserSocialMediaDto>> GetAsync(UserSocialMediaRequest model);
        Task<UserSocialMedia> AddAsync(UserSocialMediaViewModel model);
        Task<UserSocialMedia> EditAsync(UserSocialMediaViewModel model);
        Task DeleteAsync(int id);
    }
}
