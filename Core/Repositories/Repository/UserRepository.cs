using Core.EF;
using Core.Repositories.IRepository;
using Domain.DTO;
using Domain.Entities.Personal;
using Domain.Entities.System;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resources.Localizer;
using Microsoft.IdentityModel.Tokens;
using Helpers.Helpers;

namespace Core.Repositories.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
        }

        public List<UserDto> GetUsersWithParameters(string fullName)
        {

            var searchName = fullName?.Trim().ToLower();
            var userRoles = _context.UserRoles.Include(x => x.Role).ToList();
            var result = _context.Users.Include(x=> x.Gender).Where(x =>
            string.IsNullOrEmpty(searchName) || searchName.ToLower() == (x.FirstName + " " + x.LastName).ToLower()).Select(x => new UserDto
            {
                Id = x.Id,
                FullName = x.FirstName + " " + x.LastName,
                Age = DateTimeHelper.GetAge(x.BirthDate).ToString(),
                Gender = x.Gender.Name,
                ImageUrl = x.ImageUrl,
            }).ToList();

            result.ForEach(x =>
            {
                x.Role = userRoles != null ? userRoles.Where(y => y.UserId == x.Id).Select(y => y.Role.Name).FirstOrDefault() : "";
            });

            return result;
        }

        public bool DoesEmailAlreadyExist(string email) {
            return _context.UserContacts.Where(x => x.ContactTypeId == (int)Enumerations.ContactTypes.EMAIL).Any(x => x.Value == email);
        }

    }
}
