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
        IEnumerable<BasicSearchResponse> Get(BasicSearchRequest model);
        SocialMedia Add(SocialMediaViewModel model);
        SocialMedia Edit(SocialMediaViewModel model);
        void Delete(int id);
    }
}
