using Domain.DTO;
using Domain.Entities.Personal;
using Domain.Requests;
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
        Task<IEnumerable<UserContactDto>> GetAsync(UserContactRequest model);
        List<UserContact> HandleUserContacts(List<UserContactViewModel> model, int userId, string email);
        Task<UserContact> AddAsync(UserContactViewModel model);
        Task<UserContact> EditAsync(UserContactViewModel model);
        Task DeleteAsync(int id);
    }
}
