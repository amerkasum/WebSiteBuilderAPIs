using Core.Services.IService;
using Core.UnitOfWork;
using Domain.DTO;
using Microsoft.IdentityModel.Tokens;
using Resources.Localizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Service
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly Localizer Localizer;
        public UserService(IUnitOfWork unitOfWork, Localizer localizer)
        {
            this.UnitOfWork = unitOfWork;
            this.Localizer = localizer;
        }
        public IEnumerable<UserDto> GetUsersWithParameters(string fullName)
        {
            var users = UnitOfWork.User.GetUsersWithParameters(fullName);

            var result = users.Select(x => new UserDto
            {
                Id = x.Id,
                FullName = x.FullName,
                Age = string.Format(Localizer.YearsOld, x.Age),
                ImageUrl = x.ImageUrl,
                Gender = x.Gender,
                Role = x.Role
            }).AsEnumerable();

            return result;
        }
    }
}
