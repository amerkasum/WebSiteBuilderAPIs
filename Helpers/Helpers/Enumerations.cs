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
            INCORRECT_PASSWORD = 4,
            ACCESS_DENIED = 5,
            PASSWORD_RESET_REQUEST = 6,
            PASSWORD_RESET_COMPLETE = 7,
            ACCOUNT_LOCKED = 8,
            ACCOUNT_UNLOCKED = 9,
            REFRESH_TOKEN_FAILED = 10,
            REFRESH_TOKEN_SUCCESS = 11
        }
    }
}
