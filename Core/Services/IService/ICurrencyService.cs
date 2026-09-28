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
        IEnumerable<CurrencyDto> Get(BasicSearchRequest model);
        Currency Add(CurrencyViewModel model);
        Currency Edit(CurrencyViewModel model);
        void Delete(int id);
    }
}
