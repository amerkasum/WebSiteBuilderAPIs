using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.Security.Cryptography;

namespace Helpers.Helpers
{
    public static class PasswordHelper
    {
        public static string GenerateHash(string password, string salt)
        {
            var saltBytes = Convert.FromBase64String(salt);
            var hash = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(password),
                saltBytes,
                350000,
                HashAlgorithmName.SHA512,
                64);
            return Convert.ToBase64String(hash);

        }

        public static string GenerateRandomSalt()
        {
            byte[] saltBytes = RandomNumberGenerator.GetBytes(128); 
            return Convert.ToBase64String(saltBytes);
        }

    }
}
