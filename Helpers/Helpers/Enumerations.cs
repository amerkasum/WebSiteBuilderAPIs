using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Helpers
{
    public static class Enumerations
    {
        public enum ContactTypes
        {
            EMAIL = 1,
            PHONE_NUMBER = 2
        }

        public enum AuthEventTypes
        {
            LOGIN = 1,
            LOGOUT = 2,
            LOGIN_FAILED = 3,
            LOGOUT_FAILED = 4,
            INCORRECT_PASSWORD = 5,
            REFRESH_TOKEN_FAILED = 6,
            REFRESH_TOKEN_SUCCESS = 7
        }
    }
}
