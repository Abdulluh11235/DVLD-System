using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Service_Layer.Services.User_Services
{
    public class PasswordHasher : IPasswordHasher
    {
        private const int saltSize = 16;
        private const int hashSize = 32;
        private const int iters = 40042;
        private const char del = ':';
        private readonly HashAlgorithmName hashAlgorithmName = HashAlgorithmName.SHA512;

        private byte[] CoreHash(string pass, byte[] salt)
        {
            return Rfc2898DeriveBytes.Pbkdf2(pass, salt, iters, hashAlgorithmName, hashSize);
        }
        public string Hash(string pass)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(saltSize);
            byte[] hash = CoreHash(pass, salt);
            return Convert.ToHexString(salt) + del + Convert.ToHexString(hash);
        }
        public bool Verify(string pass, string passHash)
        {

            string[] saltHash = passHash.Split(del);
            byte[] salt = Convert.FromHexString(saltHash[0]);
            byte[] hash = Convert.FromHexString(saltHash[1]);

            byte[] inputhash = CoreHash(pass, salt);

            return CryptographicOperations.FixedTimeEquals(hash, inputhash);
        }

    }
}
