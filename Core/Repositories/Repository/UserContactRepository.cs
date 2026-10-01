using Core.EF;
using Core.Repositories.IRepository;
using Domain.DTO;
using Domain.Entities.Personal;
using Domain.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.Repository
{
    public class UserContactRepository : Repository<UserContact>, IUserContactRepository
    {
        public UserContactRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IEnumerable<UserContactDto> Get(UserContactRequest model)
        {
            var result = _context.UserContacts.Include(x => x.User).Include(x => x.ContactType)
                .Where(x => (!model.ContactTypeId.HasValue || model.ContactTypeId == x.ContactType.Id) && (!model.UserId.HasValue || x.User.Id == model.UserId) &&
                (string.IsNullOrEmpty(model.Sreach) || x.Value.Contains(model.Sreach))).Select(x => new UserContactDto
                {
                    Id = x.Id, 
                    User = new UserBasicDto
                    {
                        Id = x.User.Id,
                        FullName = $"{x.User.FirstName} {x.User.LastName}",
                        Username = x.User.Username,
                        Email = x.User.Email
                    },
                    ContactType = new ContactTypeDto
                    {
                        Id = x.ContactType.Id,
                        Name = x.ContactType.Name,
                        Code = x.ContactType.Code
                    },
                    Value = x.Value
                }).ToList();

            return result;
        }
    }
}
