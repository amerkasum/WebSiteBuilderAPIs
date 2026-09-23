using Domain.Entities.Personal;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.IService
{
    public interface IUserContactService
    {
        UserContact Add(UserContactViewModel model);
        UserContact Edit(UserContactViewModel model);
        void Delete(int id);
    }
}
