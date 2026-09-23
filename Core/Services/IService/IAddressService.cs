using Domain.Entities.Location;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.IService
{
    public interface IAddressService
    {
        Address Add(LocationViewModel model);
        Address Edit(LocationViewModel model);
        void Delete(int id);
    }
}
