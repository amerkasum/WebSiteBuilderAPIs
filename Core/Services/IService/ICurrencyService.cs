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
    public interface ICurrencyService
    {
        Task<IEnumerable<CurrencyDto>> GetAsync(BasicSearchRequest model);
        Task<Currency> AddAsync(CurrencyViewModel model);
        Task<Currency> EditAsync(CurrencyViewModel model);
        Task DeleteAsync(int id);
    }
}
