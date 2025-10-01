using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgApi.Utils
{
    public class Criptografia
    {
        public static void CriarPasswordHash(string password, out byte[] hash, out byte[] salt)
        {
            using (var = new System.Security.Criptography.HMACSHA512())
            {
                salt = hmac.Key;
                hash = hmac.ComputerHash(System.Text.Enconding.UTF8.GetBytes(password));
            }
        }
    }
}