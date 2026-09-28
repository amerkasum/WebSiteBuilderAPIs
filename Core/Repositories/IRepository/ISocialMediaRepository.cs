using Domain.DTO;
using Domain.Entities.System;
using Domain.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.IRepository
{
    public interface ISocialMediaRepository : IRepository<SocialMedia>
    {
        IEnumerable<BasicSearchResponse> Get(BasicSearchRequest model);
        IEnumerable<SocialMediaBasicDto> GetSocialMediaBasic();
        int GetHighestDisplayOrder();
    }
}
