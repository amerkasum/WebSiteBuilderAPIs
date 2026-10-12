using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface ILoggedUser 
    {
        int UserId { get; }
        string Username { get; }
        string Role { get; }
        string Email { get; }
        bool IsAuthenticated { get; }


    }
}
