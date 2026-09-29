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
    public interface IMessageUsService
    {
        IEnumerable<MessageUsDto> Get(MessageUsRequest model);
        MessageUs Add(MessageUsViewModel model);
        MessageUs Edit(MessageUsViewModel model);
        void Delete(int id);

    }
}
