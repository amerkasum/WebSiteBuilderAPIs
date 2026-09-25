using Domain.Entities.System;
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
        Currency Add(CurrencyViewModel model);
        Currency Edit(CurrencyViewModel model);
        void Delete(int id);
    }
}
