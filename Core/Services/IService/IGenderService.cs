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
    public interface IGenderService
    {
        Task<IEnumerable<BasicSearchResponse>> GetAsync(BasicSearchRequest model);
        Task<Gender> AddAsync(GenderViewModel model);
        Task<Gender> EditAsync(GenderViewModel model);
        Task DeleteAsync(int id);
    }
}
