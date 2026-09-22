using Domain.Entities.System;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.IService
{
    public interface IContactTypeService
    {
        ContactType Add(ContactTypeViewModel model);
        ContactType Edit(ContactTypeViewModel model);
        void Delete(int id);
    }
}
