using Domain.DTO;
using Domain.Entities.Location;
using Domain.Requests;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.IService
{
    public interface IRegionService
    {
        IEnumerable<RegionDto> Get(RegionRequest model);
        Region Add(RegionViewModel model);
        Region Edit(RegionViewModel model);
        void Delete(int id);
    }
}
