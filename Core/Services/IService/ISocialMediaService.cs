using Domain.DTO;
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
    public interface ISocialMediaService
    {
        Task<IEnumerable<BasicSearchResponse>> GetAsync(BasicSearchRequest model);
        Task<SocialMedia> AddAsync(SocialMediaViewModel model);
        Task<SocialMedia> EditAsync(SocialMediaViewModel model);
        Task DeleteAsync(int id);
    }
}
